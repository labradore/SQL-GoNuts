namespace RobEllis.SQLFormatter
{
    partial class PreviewForm
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
            this.existingText = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.previewText = new FastColoredTextBoxNS.FastColoredTextBox();
            this.ExistingCodeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.existingText)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewText)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // existingText
            // 
            this.existingText.AutoScrollMinSize = new System.Drawing.Size(123, 14);
            this.existingText.BackBrush = null;
            this.existingText.CharHeight = 14;
            this.existingText.CharWidth = 8;
            this.existingText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.existingText.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.existingText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.existingText.IsReplaceMode = false;
            this.existingText.Location = new System.Drawing.Point(3, 23);
            this.existingText.Name = "existingText";
            this.existingText.Paddings = new System.Windows.Forms.Padding(0);
            this.existingText.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.existingText.Size = new System.Drawing.Size(300, 428);
            this.existingText.TabIndex = 0;
            this.existingText.Text = "existingText";
            this.existingText.Zoom = 100;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.existingText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.previewText, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ExistingCodeLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(632, 499);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // previewText
            // 
            this.previewText.AutoScrollMinSize = new System.Drawing.Size(115, 14);
            this.previewText.BackBrush = null;
            this.previewText.CharHeight = 14;
            this.previewText.CharWidth = 8;
            this.previewText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.previewText.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.previewText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewText.IsReplaceMode = false;
            this.previewText.Location = new System.Drawing.Point(329, 23);
            this.previewText.Name = "previewText";
            this.previewText.Paddings = new System.Windows.Forms.Padding(0);
            this.previewText.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.previewText.Size = new System.Drawing.Size(300, 428);
            this.previewText.TabIndex = 1;
            this.previewText.Text = "previewText";
            this.previewText.Zoom = 100;
            // 
            // ExistingCodeLabel
            // 
            this.ExistingCodeLabel.AutoSize = true;
            this.ExistingCodeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ExistingCodeLabel.Location = new System.Drawing.Point(3, 0);
            this.ExistingCodeLabel.Name = "ExistingCodeLabel";
            this.ExistingCodeLabel.Size = new System.Drawing.Size(74, 20);
            this.ExistingCodeLabel.TabIndex = 2;
            this.ExistingCodeLabel.Text = "Existing Code:";
            this.ExistingCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(329, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Change PreviewForm:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.AcceptButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 39);
            this.panel1.TabIndex = 4;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(463, 8);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(73, 23);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(542, 8);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // PreviewForm
            // 
            this.AcceptButton = this.AcceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 499);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PreviewForm";
            this.Text = "PreviewForm";
            ((System.ComponentModel.ISupportInitialize)(this.existingText)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewText)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox existingText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FastColoredTextBoxNS.FastColoredTextBox previewText;
        private System.Windows.Forms.Label ExistingCodeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AcceptButton;
    }
}