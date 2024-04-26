namespace LogTagAutomationApp.Views
{
    partial class MainForm
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
            this.ucLogin1 = new LogTagAutomationApp.Views.ucLogin();
            this.ucMain1 = new LogTagAutomationApp.Views.ucMain();
            this.ucSearch1 = new LogTagAutomationApp.Views.ucSearch();
            this.ucTestCreate1 = new LogTagAutomationApp.Views.ucTestCreate();
            this.ucTestResult1 = new LogTagAutomationApp.Views.ucTestResult();
            this.ucSettings1 = new LogTagAutomationApp.Views.ucSettings();
            this.SuspendLayout();
            // 
            // ucLogin1
            // 
            this.ucLogin1.Location = new System.Drawing.Point(0, 0);
            this.ucLogin1.Name = "ucLogin1";
            this.ucLogin1.Size = new System.Drawing.Size(984, 661);
            this.ucLogin1.TabIndex = 0;
            // 
            // ucMain1
            // 
            this.ucMain1.Location = new System.Drawing.Point(0, 0);
            this.ucMain1.Name = "ucMain1";
            this.ucMain1.Size = new System.Drawing.Size(984, 661);
            this.ucMain1.TabIndex = 1;
            // 
            // ucSearch1
            // 
            this.ucSearch1.Location = new System.Drawing.Point(0, 0);
            this.ucSearch1.Name = "ucSearch1";
            this.ucSearch1.Size = new System.Drawing.Size(984, 661);
            this.ucSearch1.TabIndex = 2;
            // 
            // ucTestCreate1
            // 
            this.ucTestCreate1.Location = new System.Drawing.Point(0, 0);
            this.ucTestCreate1.Name = "ucTestCreate1";
            this.ucTestCreate1.Size = new System.Drawing.Size(984, 661);
            this.ucTestCreate1.TabIndex = 3;
            // 
            // ucTestResult1
            // 
            this.ucTestResult1.Location = new System.Drawing.Point(0, 0);
            this.ucTestResult1.Name = "ucTestResult1";
            this.ucTestResult1.Size = new System.Drawing.Size(984, 661);
            this.ucTestResult1.TabIndex = 4;
            // 
            // ucSettings1
            // 
            this.ucSettings1.Location = new System.Drawing.Point(0, 0);
            this.ucSettings1.Name = "ucSettings1";
            this.ucSettings1.Size = new System.Drawing.Size(984, 661);
            this.ucSettings1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.ucSettings1);
            this.Controls.Add(this.ucTestResult1);
            this.Controls.Add(this.ucTestCreate1);
            this.Controls.Add(this.ucSearch1);
            this.Controls.Add(this.ucMain1);
            this.Controls.Add(this.ucLogin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ucLogin ucLogin1;
        private ucMain ucMain1;
        private ucSearch ucSearch1;
        private ucTestCreate ucTestCreate1;
        private ucTestResult ucTestResult1;
        private ucSettings ucSettings1;
    }
}