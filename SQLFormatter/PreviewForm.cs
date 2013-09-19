using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using PoorMansTSqlFormatterLib;

namespace RobEllis.SQLFormatter
{
    public partial class PreviewForm : Form
    {

        public PreviewForm()
        {
            InitializeComponent();
            SetFormatter();
        }

        private void SetFormatter()
        {
            formatter = new PoorMansTSqlFormatterLib.Formatters.TSqlStandardFormatter(new PoorMansTSqlFormatterLib.Formatters.TSqlStandardFormatterOptions
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
            formatMgr = new SqlFormattingManager(formatter);
        }

        private void SwitchToSyntax(int lang, FastColoredTextBox fastTextBox)
        {
            fastTextBox.ClearStylesBuffer();
            fastTextBox.Range.ClearStyle(StyleIndex.All);
            fastTextBox.Language = (FastColoredTextBoxNS.Language)lang;
            fastTextBox.OnSyntaxHighlight(new TextChangedEventArgs(fastTextBox.Range));
        }

        private PoorMansTSqlFormatterLib.Interfaces.ISqlTreeFormatter formatter;
        private SqlFormattingManager formatMgr;
    }
}
