namespace LogTagAutomationApp.Views
{
    partial class ucSearch
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
            this.components = new System.ComponentModel.Container();
            this.pnlSettingsMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearchBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchSubmit = new System.Windows.Forms.Button();
            this.pnlSearchInner = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSearchControls = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSearchTester = new System.Windows.Forms.TextBox();
            this.textBoxSearchSerial = new System.Windows.Forms.TextBox();
            this.textBoxSearchBatch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSearchModel = new System.Windows.Forms.ComboBox();
            this.dtPickerSearchDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSearchResult = new System.Windows.Forms.ComboBox();
            this.btnSearchClearAll = new System.Windows.Forms.Button();
            this.dataGridViewSearchResults = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlSearchBottom = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSettingsMain.SuspendLayout();
            this.pnlSearchInner.SuspendLayout();
            this.pnlSearchControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResults)).BeginInit();
            this.pnlSearchBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSettingsMain
            // 
            this.pnlSettingsMain.ColumnCount = 3;
            this.pnlSettingsMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.pnlSettingsMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSettingsMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.pnlSettingsMain.Controls.Add(this.btnSearchBack, 0, 0);
            this.pnlSettingsMain.Controls.Add(this.label1, 1, 0);
            this.pnlSettingsMain.Controls.Add(this.pnlSearchInner, 1, 1);
            this.pnlSettingsMain.Controls.Add(this.pnlSearchBottom, 1, 2);
            this.pnlSettingsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettingsMain.Location = new System.Drawing.Point(0, 0);
            this.pnlSettingsMain.Name = "pnlSettingsMain";
            this.pnlSettingsMain.RowCount = 3;
            this.pnlSettingsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.pnlSettingsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSettingsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlSettingsMain.Size = new System.Drawing.Size(984, 661);
            this.pnlSettingsMain.TabIndex = 1;
            // 
            // btnSearchBack
            // 
            this.btnSearchBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearchBack.BackgroundImage = global::LogTagAutomationApp.Properties.Resources.icons8_back_50;
            this.btnSearchBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchBack.FlatAppearance.BorderSize = 0;
            this.btnSearchBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBack.Location = new System.Drawing.Point(3, 3);
            this.btnSearchBack.Name = "btnSearchBack";
            this.btnSearchBack.Size = new System.Drawing.Size(49, 49);
            this.btnSearchBack.TabIndex = 13;
            this.btnSearchBack.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(868, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for Logger";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearchSubmit
            // 
            this.btnSearchSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchSubmit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSearchSubmit.FlatAppearance.BorderSize = 0;
            this.btnSearchSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSubmit.Location = new System.Drawing.Point(790, 3);
            this.btnSearchSubmit.Name = "btnSearchSubmit";
            this.btnSearchSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSubmit.TabIndex = 12;
            this.btnSearchSubmit.Text = "Search";
            this.btnSearchSubmit.UseVisualStyleBackColor = false;
            // 
            // pnlSearchInner
            // 
            this.pnlSearchInner.ColumnCount = 2;
            this.pnlSearchInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.pnlSearchInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlSearchInner.Controls.Add(this.pnlSearchControls, 1, 0);
            this.pnlSearchInner.Controls.Add(this.dataGridViewSearchResults, 0, 0);
            this.pnlSearchInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchInner.Location = new System.Drawing.Point(58, 58);
            this.pnlSearchInner.Name = "pnlSearchInner";
            this.pnlSearchInner.RowCount = 1;
            this.pnlSearchInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSearchInner.Size = new System.Drawing.Size(868, 560);
            this.pnlSearchInner.TabIndex = 14;
            // 
            // pnlSearchControls
            // 
            this.pnlSearchControls.ColumnCount = 1;
            this.pnlSearchControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSearchControls.Controls.Add(this.label7, 0, 10);
            this.pnlSearchControls.Controls.Add(this.textBoxSearchTester, 0, 7);
            this.pnlSearchControls.Controls.Add(this.textBoxSearchSerial, 0, 3);
            this.pnlSearchControls.Controls.Add(this.textBoxSearchBatch, 0, 5);
            this.pnlSearchControls.Controls.Add(this.label2, 0, 0);
            this.pnlSearchControls.Controls.Add(this.label3, 0, 2);
            this.pnlSearchControls.Controls.Add(this.label4, 0, 4);
            this.pnlSearchControls.Controls.Add(this.label5, 0, 6);
            this.pnlSearchControls.Controls.Add(this.label6, 0, 8);
            this.pnlSearchControls.Controls.Add(this.comboBoxSearchModel, 0, 1);
            this.pnlSearchControls.Controls.Add(this.dtPickerSearchDate, 0, 9);
            this.pnlSearchControls.Controls.Add(this.comboBoxSearchResult, 0, 11);
            this.pnlSearchControls.Controls.Add(this.btnSearchClearAll, 0, 12);
            this.pnlSearchControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchControls.Location = new System.Drawing.Point(610, 3);
            this.pnlSearchControls.Name = "pnlSearchControls";
            this.pnlSearchControls.RowCount = 14;
            this.pnlSearchControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlSearchControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pnlSearchControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlSearchControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pnlSearchControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlSearchControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pnlSearchControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlSearchControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pnlSearchControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlSearchControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pnlSearchControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlSearchControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pnlSearchControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlSearchControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSearchControls.Size = new System.Drawing.Size(255, 554);
            this.pnlSearchControls.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Test result:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSearchTester
            // 
            this.textBoxSearchTester.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchTester.Location = new System.Drawing.Point(20, 238);
            this.textBoxSearchTester.Margin = new System.Windows.Forms.Padding(20, 8, 20, 3);
            this.textBoxSearchTester.Name = "textBoxSearchTester";
            this.textBoxSearchTester.Size = new System.Drawing.Size(215, 20);
            this.textBoxSearchTester.TabIndex = 8;
            // 
            // textBoxSearchSerial
            // 
            this.textBoxSearchSerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchSerial.Location = new System.Drawing.Point(20, 98);
            this.textBoxSearchSerial.Margin = new System.Windows.Forms.Padding(20, 8, 20, 3);
            this.textBoxSearchSerial.Name = "textBoxSearchSerial";
            this.textBoxSearchSerial.Size = new System.Drawing.Size(215, 20);
            this.textBoxSearchSerial.TabIndex = 7;
            // 
            // textBoxSearchBatch
            // 
            this.textBoxSearchBatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchBatch.Location = new System.Drawing.Point(20, 168);
            this.textBoxSearchBatch.Margin = new System.Windows.Forms.Padding(20, 8, 20, 3);
            this.textBoxSearchBatch.Name = "textBoxSearchBatch";
            this.textBoxSearchBatch.Size = new System.Drawing.Size(215, 20);
            this.textBoxSearchBatch.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Model:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Serial number:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Batch number:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tested by:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Test date:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxSearchModel
            // 
            this.comboBoxSearchModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSearchModel.FormattingEnabled = true;
            this.comboBoxSearchModel.Location = new System.Drawing.Point(20, 28);
            this.comboBoxSearchModel.Margin = new System.Windows.Forms.Padding(20, 8, 20, 3);
            this.comboBoxSearchModel.Name = "comboBoxSearchModel";
            this.comboBoxSearchModel.Size = new System.Drawing.Size(215, 21);
            this.comboBoxSearchModel.TabIndex = 9;
            // 
            // dtPickerSearchDate
            // 
            this.dtPickerSearchDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPickerSearchDate.Location = new System.Drawing.Point(20, 308);
            this.dtPickerSearchDate.Margin = new System.Windows.Forms.Padding(20, 8, 20, 3);
            this.dtPickerSearchDate.Name = "dtPickerSearchDate";
            this.dtPickerSearchDate.Size = new System.Drawing.Size(215, 20);
            this.dtPickerSearchDate.TabIndex = 10;
            // 
            // comboBoxSearchResult
            // 
            this.comboBoxSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSearchResult.FormattingEnabled = true;
            this.comboBoxSearchResult.Location = new System.Drawing.Point(20, 378);
            this.comboBoxSearchResult.Margin = new System.Windows.Forms.Padding(20, 8, 20, 3);
            this.comboBoxSearchResult.Name = "comboBoxSearchResult";
            this.comboBoxSearchResult.Size = new System.Drawing.Size(215, 21);
            this.comboBoxSearchResult.TabIndex = 12;
            // 
            // btnSearchClearAll
            // 
            this.btnSearchClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchClearAll.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearchClearAll.FlatAppearance.BorderSize = 0;
            this.btnSearchClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClearAll.Location = new System.Drawing.Point(177, 423);
            this.btnSearchClearAll.Name = "btnSearchClearAll";
            this.btnSearchClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnSearchClearAll.TabIndex = 13;
            this.btnSearchClearAll.Text = "Clear all";
            this.btnSearchClearAll.UseVisualStyleBackColor = false;
            // 
            // dataGridViewSearchResults
            // 
            this.dataGridViewSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSearchResults.Location = new System.Drawing.Point(20, 3);
            this.dataGridViewSearchResults.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.dataGridViewSearchResults.Name = "dataGridViewSearchResults";
            this.dataGridViewSearchResults.Size = new System.Drawing.Size(567, 554);
            this.dataGridViewSearchResults.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(20, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(394, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Double Click on a cell to open the File Location in Windows Explorer";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlSearchBottom
            // 
            this.pnlSearchBottom.ColumnCount = 2;
            this.pnlSearchBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlSearchBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlSearchBottom.Controls.Add(this.btnSearchSubmit, 1, 0);
            this.pnlSearchBottom.Controls.Add(this.label8, 0, 0);
            this.pnlSearchBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchBottom.Location = new System.Drawing.Point(58, 624);
            this.pnlSearchBottom.Name = "pnlSearchBottom";
            this.pnlSearchBottom.RowCount = 1;
            this.pnlSearchBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSearchBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlSearchBottom.Size = new System.Drawing.Size(868, 34);
            this.pnlSearchBottom.TabIndex = 15;
            // 
            // ucSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSettingsMain);
            this.Name = "ucSearch";
            this.Size = new System.Drawing.Size(984, 661);
            this.pnlSettingsMain.ResumeLayout(false);
            this.pnlSettingsMain.PerformLayout();
            this.pnlSearchInner.ResumeLayout(false);
            this.pnlSearchControls.ResumeLayout(false);
            this.pnlSearchControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResults)).EndInit();
            this.pnlSearchBottom.ResumeLayout(false);
            this.pnlSearchBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlSettingsMain;
        private System.Windows.Forms.Button btnSearchBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchSubmit;
        private System.Windows.Forms.TableLayoutPanel pnlSearchInner;
        private System.Windows.Forms.TableLayoutPanel pnlSearchControls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSearchTester;
        private System.Windows.Forms.TextBox textBoxSearchSerial;
        private System.Windows.Forms.TextBox textBoxSearchBatch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSearchModel;
        private System.Windows.Forms.DateTimePicker dtPickerSearchDate;
        private System.Windows.Forms.ComboBox comboBoxSearchResult;
        private System.Windows.Forms.Button btnSearchClearAll;
        private System.Windows.Forms.DataGridView dataGridViewSearchResults;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel pnlSearchBottom;
    }
}
