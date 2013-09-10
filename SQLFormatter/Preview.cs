using System;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace RobEllis.SQLFormatter
{
    public partial class Preview : Form
    {
        public string ResultText { get { return sqlXformer.ResultText; } }

        public Preview(ISQLTransformer xformer)
        {
            InitializeComponent();

            sqlXformer = xformer;
            // SourceTextBox.DataBindings.Add("Text", sqlXformer, "SourceText");
            // ResultTextBox.DataBindings.Add("Text", sqlXformer, "ResultText");
            SourceTextBox.Text = xformer.SourceText;
            ResultTextBox.Text = xformer.ResultText;

            SetSyntax((int)Language.VB, SourceTextBox);
            SetSyntax((int)Language.VB, ResultTextBox);
        }

        private void UpdateResult()
        {
            ResultTextBox.Text = sqlXformer.ResultText;
        }

        private void UpdateSource(string newsource)
        {
            sqlXformer.SourceText = newsource;
            SourceTextBox.Text = sqlXformer.SourceText;
        }

        private void SetSyntax(int lang, FastColoredTextBox fctBox)
        {
            fctBox.ClearStylesBuffer();
            fctBox.Range.ClearStyle(StyleIndex.All);
            fctBox.Language = (FastColoredTextBoxNS.Language)lang;
            fctBox.OnSyntaxHighlight(new TextChangedEventArgs(fctBox.Range));
        }

        private void NewLine_Changed(object sender, EventArgs e)
        {
            NewlinesCombo.Enabled = UseNewLines.Checked;
            sqlXformer.NewLineText = NewlinesCombo.Enabled ? NewlinesCombo.Text : "";
            UpdateResult();
        }

        private readonly ISQLTransformer sqlXformer;

        private void Button_Click(object sender, EventArgs e)
        {
            switch (((Button) sender).Name)
            {
                case "Accept_Button":
                    DialogResult = DialogResult.OK;
                    break;
                case "Cancel_Button":
                    DialogResult = DialogResult.Cancel;
                    break;
            }
        }

        private void StringStyle_Changed(object sender, EventArgs e)
        {
            sqlXformer.UseInlineVariables = UseInlineVariables.Checked;
            UpdateResult();
        }
    }
}
