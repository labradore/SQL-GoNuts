namespace RobEllis.SQLFormatter
{
    partial class Preview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CurrentTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.PreviewTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PreviewLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Accept_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.UseInlineVariables = new System.Windows.Forms.RadioButton();
            this.UseFormatterVariables = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewTextBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentTextBox
            // 
            this.CurrentTextBox.AutoScrollMinSize = new System.Drawing.Size(129, 21);
            this.CurrentTextBox.BackBrush = null;
            this.CurrentTextBox.CharHeight = 15;
            this.CurrentTextBox.CharWidth = 7;
            this.CurrentTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CurrentTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CurrentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTextBox.IsReplaceMode = false;
            this.CurrentTextBox.Location = new System.Drawing.Point(11, 23);
            this.CurrentTextBox.Name = "CurrentTextBox";
            this.CurrentTextBox.Paddings = new System.Windows.Forms.Padding(3);
            this.CurrentTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.CurrentTextBox.Size = new System.Drawing.Size(312, 306);
            this.CurrentTextBox.TabIndex = 0;
            this.CurrentTextBox.Text = "CurrentTextBox";
            this.CurrentTextBox.Zoom = 100;
            // 
            // PreviewTextBox
            // 
            this.PreviewTextBox.AutoScrollMinSize = new System.Drawing.Size(129, 21);
            this.PreviewTextBox.BackBrush = null;
            this.PreviewTextBox.CharHeight = 15;
            this.PreviewTextBox.CharWidth = 7;
            this.PreviewTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PreviewTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.PreviewTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewTextBox.IsReplaceMode = false;
            this.PreviewTextBox.Location = new System.Drawing.Point(349, 23);
            this.PreviewTextBox.Name = "PreviewTextBox";
            this.PreviewTextBox.Paddings = new System.Windows.Forms.Padding(3);
            this.PreviewTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.PreviewTextBox.Size = new System.Drawing.Size(312, 306);
            this.PreviewTextBox.TabIndex = 1;
            this.PreviewTextBox.Text = "PreviewTextBox";
            this.PreviewTextBox.Zoom = 100;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Controls.Add(this.PreviewTextBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.CurrentTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PreviewLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(673, 397);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // PreviewLabel
            // 
            this.PreviewLabel.AutoSize = true;
            this.PreviewLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PreviewLabel.Location = new System.Drawing.Point(349, 3);
            this.PreviewLabel.Margin = new System.Windows.Forms.Padding(3);
            this.PreviewLabel.Name = "PreviewLabel";
            this.PreviewLabel.Size = new System.Drawing.Size(48, 14);
            this.PreviewLabel.TabIndex = 2;
            this.PreviewLabel.Text = "Preview:";
            this.PreviewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(11, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 5);
            this.panel1.Controls.Add(this.UseFormatterVariables);
            this.panel1.Controls.Add(this.UseInlineVariables);
            this.panel1.Controls.Add(this.Cancel_Button);
            this.panel1.Controls.Add(this.Accept_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 332);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 65);
            this.panel1.TabIndex = 4;
            // 
            // Accept_Button
            // 
            this.Accept_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Accept_Button.Location = new System.Drawing.Point(505, 30);
            this.Accept_Button.Name = "Accept_Button";
            this.Accept_Button.Size = new System.Drawing.Size(75, 23);
            this.Accept_Button.TabIndex = 0;
            this.Accept_Button.Text = "Accept";
            this.Accept_Button.UseVisualStyleBackColor = true;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel_Button.Location = new System.Drawing.Point(586, 30);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // UseInlineVariables
            // 
            this.UseInlineVariables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UseInlineVariables.AutoSize = true;
            this.UseInlineVariables.Location = new System.Drawing.Point(11, 34);
            this.UseInlineVariables.Name = "UseInlineVariables";
            this.UseInlineVariables.Size = new System.Drawing.Size(125, 17);
            this.UseInlineVariables.TabIndex = 2;
            this.UseInlineVariables.Text = "Use In-Line Variables";
            this.UseInlineVariables.UseVisualStyleBackColor = true;
            // 
            // UseFormatterVariables
            // 
            this.UseFormatterVariables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UseFormatterVariables.AutoSize = true;
            this.UseFormatterVariables.Checked = true;
            this.UseFormatterVariables.Location = new System.Drawing.Point(11, 11);
            this.UseFormatterVariables.Name = "UseFormatterVariables";
            this.UseFormatterVariables.Size = new System.Drawing.Size(155, 17);
            this.UseFormatterVariables.TabIndex = 3;
            this.UseFormatterVariables.TabStop = true;
            this.UseFormatterVariables.Text = "Use String.Format Variables";
            this.UseFormatterVariables.UseVisualStyleBackColor = true;
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 397);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Preview";
            this.Text = "Preview";
            ((System.ComponentModel.ISupportInitialize)(this.CurrentTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewTextBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox CurrentTextBox;
        private FastColoredTextBoxNS.FastColoredTextBox PreviewTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label PreviewLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton UseFormatterVariables;
        private System.Windows.Forms.RadioButton UseInlineVariables;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Accept_Button;
    }
}