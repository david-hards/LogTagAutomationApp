namespace LogTagAutomationApp.Views
{
    partial class ucLogin
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
            this.pnlLoginMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelLoginInner = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.btnLoginSubmit = new System.Windows.Forms.Button();
            this.pnlLoginMain.SuspendLayout();
            this.panelLoginInner.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLoginMain
            // 
            this.pnlLoginMain.ColumnCount = 3;
            this.pnlLoginMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlLoginMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlLoginMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlLoginMain.Controls.Add(this.panelLoginInner, 1, 1);
            this.pnlLoginMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoginMain.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginMain.Name = "pnlLoginMain";
            this.pnlLoginMain.RowCount = 3;
            this.pnlLoginMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlLoginMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlLoginMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlLoginMain.Size = new System.Drawing.Size(984, 661);
            this.pnlLoginMain.TabIndex = 0;
            // 
            // panelLoginInner
            // 
            this.panelLoginInner.ColumnCount = 1;
            this.panelLoginInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelLoginInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelLoginInner.Controls.Add(this.label1, 0, 0);
            this.panelLoginInner.Controls.Add(this.label2, 0, 2);
            this.panelLoginInner.Controls.Add(this.textBoxLogin, 0, 3);
            this.panelLoginInner.Controls.Add(this.btnLoginSubmit, 0, 4);
            this.panelLoginInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoginInner.Location = new System.Drawing.Point(331, 223);
            this.panelLoginInner.Name = "panelLoginInner";
            this.panelLoginInner.RowCount = 6;
            this.panelLoginInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelLoginInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLoginInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelLoginInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelLoginInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelLoginInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelLoginInner.Size = new System.Drawing.Size(322, 214);
            this.panelLoginInner.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "LogTag QA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name of Tester:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(3, 100);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(316, 21);
            this.textBoxLogin.TabIndex = 2;
            // 
            // btnLoginSubmit
            // 
            this.btnLoginSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginSubmit.Location = new System.Drawing.Point(244, 135);
            this.btnLoginSubmit.Name = "btnLoginSubmit";
            this.btnLoginSubmit.Size = new System.Drawing.Size(75, 34);
            this.btnLoginSubmit.TabIndex = 3;
            this.btnLoginSubmit.Text = "Log in";
            this.btnLoginSubmit.UseVisualStyleBackColor = true;
            // 
            // ucLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlLoginMain);
            this.Name = "ucLogin";
            this.Size = new System.Drawing.Size(984, 661);
            this.pnlLoginMain.ResumeLayout(false);
            this.panelLoginInner.ResumeLayout(false);
            this.panelLoginInner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlLoginMain;
        private System.Windows.Forms.TableLayoutPanel panelLoginInner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button btnLoginSubmit;
    }
}
