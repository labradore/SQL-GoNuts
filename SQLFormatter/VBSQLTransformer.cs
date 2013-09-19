using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using PoorMansTSqlFormatterLib;

namespace RobEllis.SQLFormatter
{
    /// <summary>
    /// 
    /// </summary>
    public class VbsqlTransformer : ISQLTransformer, INotifyPropertyChanged
    {
        public VbsqlTransformer(string src = "")
        {
            SetFormatter();
            newline = "NewLine";
            useInlineVariables = false;
            result = Transform(src);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        // ISourceTransformer.Transform
        public string Transform(string src)
        {
            source = src;
            cleaned = CleanUpInput(source, out variables);
            formatted = FormatSQL(cleaned);
            literalized = LiteralToVB(formatted);
            return ReplaceVariables(literalized, variables);

        }

        string ISourceTransformer.SourceText
        {
            get { return source; }
            set
            {
                source = value;
                result = Transform(source);
                NotifyPropertyChanged("SourceText");
                NotifyPropertyChanged("ResultText");
            }
        }

        string ISourceTransformer.ResultText { get { return result; } }
        bool ISQLTransformer.UseInlineVariables
        {
            get
            {
                return useInlineVariables;
            }
            set
            {
                useInlineVariables = value;
                result = Transform(source);
                NotifyPropertyChanged("UseInlineVariables");
                NotifyPropertyChanged("ResultText");
            }
        }
        string ISQLTransformer.NewLineText
        {
            get {return newline;}
            set
            {
                newline = value;
                result = Transform(source);
                NotifyPropertyChanged("NewLineText");
                NotifyPropertyChanged("ResultText");
            }
        }
        public IReadOnlyList<string> Variables { get { return variables; } }

        private void SetFormatter()
        {
            formatter = new PoorMansTSqlFormatterLib.Formatters.TSqlStandardFormatter(
                new PoorMansTSqlFormatterLib.Formatters.TSqlStandardFormatterOptions
                {
                    IndentString = "\t",
                    SpacesPerTab = 4,
                    MaxLineWidth = 999,
                    ExpandCommaLists = true,
                    TrailingCommas = true,
                    SpaceAfterExpandedComma = false,
                    ExpandBooleanExpressions = true,
                    ExpandCaseStatements = true,
                    ExpandBetweenConditions = false,
                    BreakJoinOnSections = false,
                    UppercaseKeywords = true,
                    HTMLColoring = false,
                    KeywordStandardization = true
                });
            formatManager = new SqlFormattingManager(formatter);
        }

        private string FormatSQL(string input)
        {
            StringBuilder buffer = new StringBuilder(formatManager.Format(input));
            return buffer.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="vars"></param>
        /// <returns></returns>
        private string CleanUpInput(string input, out List<string> vars)
        {
            var literals = Regex.Matches(input, "(\".+?\")");
            var varStrings = Regex.Matches(input, "\"\\s+&\\s+([a-zA-Z0-9_]+)(\\s+&\\s+\")?");
            //var allwords = Regex.Matches(input, "\\w(?<!\\d)[\\w]*").Cast<string>().ToList();
            vars = varStrings.Cast<Match>().Select(m => "__REPL__" + m.Groups[1].Value.ToString()).ToList();

            var sb = new StringBuilder();
            var sorted = new SortedDictionary<int, string>(literals.Cast<Match>().ToDictionary(m => m.Index, m => m.Value.ToString()));
            foreach (Match m in varStrings)
                sorted.Add(m.Index, "__REPL__" + m.Groups[1].Value.ToString());

            // since sorted is sorted by key, the list of vars and literals is in order
            // just strip the quotes (ampersands already removed with regexes
            foreach (int i in sorted.Keys)
                sb.Append(sorted[i].Trim("\"".ToCharArray()));
            return sb.ToString();
        }

        private string LiteralToVB(string literal)
        {
            string[] lines = literal.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();

            foreach (String line in lines)
            {
                Match m = Regex.Match(line, String.Format("\"(.+?)\" & {0}( &)?", newline), RegexOptions.Compiled);
                if (m.Groups.Count > 1)
                {
                    sb.AppendLine(line);
                }
                else
                {
                    if (newline.Length > 0)
                        sb.AppendFormat("\"{0}\" & {1} &\r\n", line, newline);
                    else
                        sb.AppendFormat("\"{0}\" &\r\n", line);
                }
            }
            return sb.ToString().TrimEnd(" &\r\n".ToCharArray()) + "\r\n";
        }

        private string ReplaceVariables(string src, IReadOnlyList<string> vars)
        {
            if (!useInlineVariables)
            {
                var sb = new StringBuilder().Append("Dim newQuery as String = _\r\n");
                sb.Append(src);
                sb.Append("newQuery = String.Format(newQuery,");
                for (var i = 0; i < vars.Count; i++)
                {
                    sb.Replace(vars[i], String.Format("{{0}}", i));
                    sb.Append(" " + vars[i].Substring(8) + ", ");
                }
                sb.Remove(sb.Length - 2, 2);
                sb.Append(")\r\n");
                return sb.ToString();
            }
            else
            {
                var sb = new StringBuilder();
                sb.Append(src);
                foreach (string v in vars)
                {
                    sb.Replace(v, String.Format("\" & {0} & \"", v.Substring(8)));
                }
                return sb.ToString();
            }
           
        }

        private PoorMansTSqlFormatterLib.Interfaces.ISqlTreeFormatter formatter;
        private PoorMansTSqlFormatterLib.SqlFormattingManager formatManager;
        private string source;
        private string cleaned;
        private string formatted;
        private string literalized;
        private string result;
        private string newline;
        private List<string> variables;
        private bool useInlineVariables;
    }
}
