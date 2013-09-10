using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using PoorMansTSqlFormatterLib;

namespace RobEllis.SQLFormatter
{
    public partial class Preview : Form
    {
        public string Source
        {
            get { return sqlXformer.ResultText; }
        }

        public Preview(ISQLTransformer xformer)
        {
            InitializeComponent();

            sqlXformer = xformer;
            CurrentTextBox.Text = xformer.SourceText;
            //UpdateUI();
            PreviewTextBox.Text = xformer.ResultText;

            SetSyntax((int)Language.VB, CurrentTextBox);
            SetSyntax((int)Language.VB, PreviewTextBox);
        }

        private void UpdateUI()
        {
            PreviewTextBox.Text = sqlXformer.ResultText;
        }

        private void SetSyntax(int lang, FastColoredTextBox fctBox)
        {
            fctBox.ClearStylesBuffer();
            fctBox.Range.ClearStyle(StyleIndex.All);
            fctBox.Language = (FastColoredTextBoxNS.Language)lang;
            fctBox.OnSyntaxHighlight(new TextChangedEventArgs(fctBox.Range));
        }

        private ISQLTransformer sqlXformer;
    }

    /// <summary>
    /// 
    /// </summary>
    public class VBSQLTransformer : ISQLTransformer
    {
        public VBSQLTransformer(string src = "")
        {
            SetFormatter();
            result = Transform(src);
        }
        
        public string Transform(string src)
        {
            source = CleanUpInput(src, out variables);
            source = FormatSQL(source);
            source = LiteralToVB(source);
            source = ReplaceVariables(source, variables);
            return source;
        }

        public string SourceText
        {
            get { return source; }
            set { source = value; result = Transform(source);}
        }

        public string ResultText { get { return result; } }
        public bool UseInlineVariables { get; set; }
        public bool KeepNewlines { get; set; }
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

            foreach (String line in lines) {
                Match m = Regex.Match(line, "\"(.+?)\" & NewLine( &)?", RegexOptions.Compiled);
                if (m.Groups.Count > 1)
                {
                    sb.AppendLine(line);
                }
                else
                {
                    sb.AppendFormat("\"{0}\" & NewLine &\r\n", line);
                }
            }
            return sb.ToString().TrimEnd(" &\r\n".ToCharArray()) + "\r\n";
        }

        private string ReplaceVariables(string src, IReadOnlyList<string> vars)
        {
            var sb = new StringBuilder().Append("Dim newQuery as String = _\r\n");
            sb.Append(src);
            sb.Append("newQuery = String.Format(newQuery,");
            for (int i = 0; i < vars.Count; i++)
            {
                sb.Replace(vars[i], String.Format("{{0}}", i));
                sb.Append(" " + vars[i].Substring(8) + ", ");
            }
            sb.Remove(sb.Length - 2, 2);
            sb.Append(")\r\n");
            return sb.ToString();
        }

        private PoorMansTSqlFormatterLib.Interfaces.ISqlTreeFormatter formatter;
        private PoorMansTSqlFormatterLib.SqlFormattingManager formatManager;
        private string source;
        private string result;
        private List<string> variables;
    }

   


}
