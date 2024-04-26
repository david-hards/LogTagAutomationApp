namespace LogTagAutomationApp.Views
{
    partial class ucMain
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
            this.pnlMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnMainGoTest = new System.Windows.Forms.Button();
            this.btnMainGoSearch = new System.Windows.Forms.Button();
            this.btnMainGoSettings = new System.Windows.Forms.Button();
            this.pnlMainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainLayout
            // 
            this.pnlMainLayout.ColumnCount = 5;
            this.pnlMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.pnlMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.pnlMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.pnlMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMainLayout.Controls.Add(this.btnMainGoTest, 1, 1);
            this.pnlMainLayout.Controls.Add(this.btnMainGoSearch, 2, 1);
            this.pnlMainLayout.Controls.Add(this.btnMainGoSettings, 3, 1);
            this.pnlMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainLayout.Location = new System.Drawing.Point(0, 0);
            this.pnlMainLayout.Name = "pnlMainLayout";
            this.pnlMainLayout.RowCount = 3;
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.pnlMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMainLayout.Size = new System.Drawing.Size(984, 661);
            this.pnlMainLayout.TabIndex = 0;
            // 
            // btnMainGoTest
            // 
            this.btnMainGoTest.BackgroundImage = global::LogTagAutomationApp.Properties.Resources.icons8_add_100;
            this.btnMainGoTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainGoTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMainGoTest.FlatAppearance.BorderSize = 0;
            this.btnMainGoTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainGoTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainGoTest.Location = new System.Drawing.Point(195, 233);
            this.btnMainGoTest.Name = "btnMainGoTest";
            this.btnMainGoTest.Size = new System.Drawing.Size(194, 194);
            this.btnMainGoTest.TabIndex = 0;
            this.btnMainGoTest.Text = "Start new Test";
            this.btnMainGoTest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMainGoTest.UseVisualStyleBackColor = true;
            // 
            // btnMainGoSearch
            // 
            this.btnMainGoSearch.BackgroundImage = global::LogTagAutomationApp.Properties.Resources.icons8_search_in_browser_100;
            this.btnMainGoSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainGoSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMainGoSearch.FlatAppearance.BorderSize = 0;
            this.btnMainGoSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainGoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainGoSearch.Location = new System.Drawing.Point(395, 233);
            this.btnMainGoSearch.Name = "btnMainGoSearch";
            this.btnMainGoSearch.Size = new System.Drawing.Size(194, 194);
            this.btnMainGoSearch.TabIndex = 3;
            this.btnMainGoSearch.Text = "Search";
            this.btnMainGoSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMainGoSearch.UseVisualStyleBackColor = true;
            // 
            // btnMainGoSettings
            // 
            this.btnMainGoSettings.BackgroundImage = global::LogTagAutomationApp.Properties.Resources.icons8_adjust_100;
            this.btnMainGoSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainGoSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMainGoSettings.FlatAppearance.BorderSize = 0;
            this.btnMainGoSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainGoSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainGoSettings.Location = new System.Drawing.Point(595, 233);
            this.btnMainGoSettings.Name = "btnMainGoSettings";
            this.btnMainGoSettings.Size = new System.Drawing.Size(194, 194);
            this.btnMainGoSettings.TabIndex = 2;
            this.btnMainGoSettings.Text = "Settings";
            this.btnMainGoSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMainGoSettings.UseVisualStyleBackColor = true;
            // 
            // ucMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMainLayout);
            this.Name = "ucMain";
            this.Size = new System.Drawing.Size(984, 661);
            this.pnlMainLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMainLayout;
        private System.Windows.Forms.Button btnMainGoTest;
        private System.Windows.Forms.Button btnMainGoSearch;
        private System.Windows.Forms.Button btnMainGoSettings;
    }
}
