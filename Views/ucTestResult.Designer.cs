namespace LogTagAutomationApp.Views
{
    partial class ucTestResult
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
            this.lblSettingsMain = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTestResultFinish = new System.Windows.Forms.Button();
            this.btnTestResultBack = new System.Windows.Forms.Button();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.Setpoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dostmann = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSettingsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSettingsMain
            // 
            this.lblSettingsMain.ColumnCount = 3;
            this.lblSettingsMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.lblSettingsMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lblSettingsMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.lblSettingsMain.Controls.Add(this.btnTestResultBack, 0, 0);
            this.lblSettingsMain.Controls.Add(this.label1, 1, 0);
            this.lblSettingsMain.Controls.Add(this.btnTestResultFinish, 1, 2);
            this.lblSettingsMain.Controls.Add(this.dataGridViewResults, 1, 1);
            this.lblSettingsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSettingsMain.Location = new System.Drawing.Point(0, 0);
            this.lblSettingsMain.Name = "lblSettingsMain";
            this.lblSettingsMain.RowCount = 3;
            this.lblSettingsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.lblSettingsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lblSettingsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.lblSettingsMain.Size = new System.Drawing.Size(984, 661);
            this.lblSettingsMain.TabIndex = 0;
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
            this.label1.Text = "Test Result";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTestResultFinish
            // 
            this.btnTestResultFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestResultFinish.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTestResultFinish.FlatAppearance.BorderSize = 0;
            this.btnTestResultFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestResultFinish.Location = new System.Drawing.Point(851, 624);
            this.btnTestResultFinish.Name = "btnTestResultFinish";
            this.btnTestResultFinish.Size = new System.Drawing.Size(75, 23);
            this.btnTestResultFinish.TabIndex = 12;
            this.btnTestResultFinish.Text = "Finish";
            this.btnTestResultFinish.UseVisualStyleBackColor = false;
            // 
            // btnTestResultBack
            // 
            this.btnTestResultBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnTestResultBack.BackgroundImage = global::LogTagAutomationApp.Properties.Resources.icons8_back_50;
            this.btnTestResultBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTestResultBack.FlatAppearance.BorderSize = 0;
            this.btnTestResultBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestResultBack.Location = new System.Drawing.Point(3, 3);
            this.btnTestResultBack.Name = "btnTestResultBack";
            this.btnTestResultBack.Size = new System.Drawing.Size(49, 49);
            this.btnTestResultBack.TabIndex = 13;
            this.btnTestResultBack.UseVisualStyleBackColor = false;
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Setpoint,
            this.Dostmann});
            this.dataGridViewResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResults.Location = new System.Drawing.Point(58, 58);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.Size = new System.Drawing.Size(868, 560);
            this.dataGridViewResults.TabIndex = 14;
            // 
            // Setpoint
            // 
            this.Setpoint.HeaderText = "Setpoint";
            this.Setpoint.Name = "Setpoint";
            // 
            // Dostmann
            // 
            this.Dostmann.HeaderText = "Dostmann";
            this.Dostmann.Name = "Dostmann";
            // 
            // ucTestResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSettingsMain);
            this.Name = "ucTestResult";
            this.Size = new System.Drawing.Size(984, 661);
            this.lblSettingsMain.ResumeLayout(false);
            this.lblSettingsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel lblSettingsMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTestResultBack;
        private System.Windows.Forms.Button btnTestResultFinish;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setpoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dostmann;
    }
}
