namespace LogTagAutomationApp.Views
{
    partial class ucTestCreate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTestMain = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxDostmann = new System.Windows.Forms.ListBox();
            this.comboBoxLoggers = new System.Windows.Forms.ComboBox();
            this.btnTestClearDostmann = new System.Windows.Forms.Button();
            this.btnCreateTestBack = new System.Windows.Forms.Button();
            this.btnTestClearLTD = new System.Windows.Forms.Button();
            this.btnTestCreate = new System.Windows.Forms.Button();
            this.listBoxLTD = new System.Windows.Forms.ListBox();
            this.textBoxBatchNumber = new System.Windows.Forms.TextBox();
            this.pnlTestMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTestMain
            // 
            this.pnlTestMain.ColumnCount = 5;
            this.pnlTestMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.pnlTestMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlTestMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlTestMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlTestMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.pnlTestMain.Controls.Add(this.btnCreateTestBack, 0, 0);
            this.pnlTestMain.Controls.Add(this.label1, 1, 2);
            this.pnlTestMain.Controls.Add(this.label2, 2, 2);
            this.pnlTestMain.Controls.Add(this.label3, 3, 2);
            this.pnlTestMain.Controls.Add(this.label4, 2, 0);
            this.pnlTestMain.Controls.Add(this.listBoxDostmann, 1, 3);
            this.pnlTestMain.Controls.Add(this.comboBoxLoggers, 3, 3);
            this.pnlTestMain.Controls.Add(this.btnTestClearDostmann, 1, 4);
            this.pnlTestMain.Controls.Add(this.btnTestClearLTD, 2, 4);
            this.pnlTestMain.Controls.Add(this.btnTestCreate, 3, 5);
            this.pnlTestMain.Controls.Add(this.listBoxLTD, 2, 3);
            this.pnlTestMain.Controls.Add(this.textBoxBatchNumber, 3, 4);
            this.pnlTestMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTestMain.Location = new System.Drawing.Point(0, 0);
            this.pnlTestMain.Name = "pnlTestMain";
            this.pnlTestMain.RowCount = 7;
            this.pnlTestMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.pnlTestMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlTestMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlTestMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.pnlTestMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlTestMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlTestMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlTestMain.Size = new System.Drawing.Size(984, 661);
            this.pnlTestMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(58, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drag in Dostmann .dbf file:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(349, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drag in logger .ltd files";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(640, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Logger type:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 55);
            this.label4.TabIndex = 3;
            this.label4.Text = "New Test";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxDostmann
            // 
            this.listBoxDostmann.AllowDrop = true;
            this.listBoxDostmann.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDostmann.FormattingEnabled = true;
            this.listBoxDostmann.Location = new System.Drawing.Point(75, 138);
            this.listBoxDostmann.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.listBoxDostmann.Name = "listBoxDostmann";
            this.listBoxDostmann.Size = new System.Drawing.Size(251, 395);
            this.listBoxDostmann.TabIndex = 4;
            // 
            // comboBoxLoggers
            // 
            this.comboBoxLoggers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLoggers.FormattingEnabled = true;
            this.comboBoxLoggers.Location = new System.Drawing.Point(657, 138);
            this.comboBoxLoggers.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.comboBoxLoggers.Name = "comboBoxLoggers";
            this.comboBoxLoggers.Size = new System.Drawing.Size(251, 21);
            this.comboBoxLoggers.TabIndex = 6;
            // 
            // btnTestClearDostmann
            // 
            this.btnTestClearDostmann.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTestClearDostmann.FlatAppearance.BorderSize = 0;
            this.btnTestClearDostmann.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestClearDostmann.Location = new System.Drawing.Point(75, 539);
            this.btnTestClearDostmann.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btnTestClearDostmann.Name = "btnTestClearDostmann";
            this.btnTestClearDostmann.Size = new System.Drawing.Size(251, 34);
            this.btnTestClearDostmann.TabIndex = 8;
            this.btnTestClearDostmann.Text = "Clear Dostmann Files";
            this.btnTestClearDostmann.UseVisualStyleBackColor = true;
            // 
            // btnCreateTestBack
            // 
            this.btnCreateTestBack.BackgroundImage = global::LogTagAutomationApp.Properties.Resources.icons8_back_50;
            this.btnCreateTestBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateTestBack.FlatAppearance.BorderSize = 0;
            this.btnCreateTestBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTestBack.Location = new System.Drawing.Point(3, 3);
            this.btnCreateTestBack.Name = "btnCreateTestBack";
            this.btnCreateTestBack.Size = new System.Drawing.Size(49, 49);
            this.btnCreateTestBack.TabIndex = 9;
            this.btnCreateTestBack.UseVisualStyleBackColor = true;
            // 
            // btnTestClearLTD
            // 
            this.btnTestClearLTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTestClearLTD.FlatAppearance.BorderSize = 0;
            this.btnTestClearLTD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestClearLTD.Location = new System.Drawing.Point(366, 539);
            this.btnTestClearLTD.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btnTestClearLTD.Name = "btnTestClearLTD";
            this.btnTestClearLTD.Size = new System.Drawing.Size(251, 34);
            this.btnTestClearLTD.TabIndex = 10;
            this.btnTestClearLTD.Text = "Clear LTD files";
            this.btnTestClearLTD.UseVisualStyleBackColor = true;
            // 
            // btnTestCreate
            // 
            this.btnTestCreate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTestCreate.FlatAppearance.BorderSize = 0;
            this.btnTestCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestCreate.Location = new System.Drawing.Point(657, 581);
            this.btnTestCreate.Margin = new System.Windows.Forms.Padding(20, 5, 20, 3);
            this.btnTestCreate.Name = "btnTestCreate";
            this.btnTestCreate.Size = new System.Drawing.Size(251, 34);
            this.btnTestCreate.TabIndex = 11;
            this.btnTestCreate.Text = "Create test";
            this.btnTestCreate.UseVisualStyleBackColor = false;
            // 
            // listBoxLTD
            // 
            this.listBoxLTD.AllowDrop = true;
            this.listBoxLTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLTD.FormattingEnabled = true;
            this.listBoxLTD.Location = new System.Drawing.Point(366, 138);
            this.listBoxLTD.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.listBoxLTD.Name = "listBoxLTD";
            this.listBoxLTD.Size = new System.Drawing.Size(251, 395);
            this.listBoxLTD.TabIndex = 12;
            // 
            // textBoxBatchNumber
            // 
            this.textBoxBatchNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBatchNumber.Location = new System.Drawing.Point(657, 546);
            this.textBoxBatchNumber.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.textBoxBatchNumber.Name = "textBoxBatchNumber";
            this.textBoxBatchNumber.Size = new System.Drawing.Size(251, 20);
            this.textBoxBatchNumber.TabIndex = 13;
            // 
            // ucTestCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTestMain);
            this.Name = "ucTestCreate";
            this.Size = new System.Drawing.Size(984, 661);
            this.pnlTestMain.ResumeLayout(false);
            this.pnlTestMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlTestMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateTestBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxDostmann;
        private System.Windows.Forms.ComboBox comboBoxLoggers;
        private System.Windows.Forms.Button btnTestClearDostmann;
        private System.Windows.Forms.Button btnTestClearLTD;
        private System.Windows.Forms.Button btnTestCreate;
        private System.Windows.Forms.ListBox listBoxLTD;
        private System.Windows.Forms.TextBox textBoxBatchNumber;
    }
}
