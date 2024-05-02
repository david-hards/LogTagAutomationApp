using LogTagAutomationApp.Controllers;
using QualityAutomation.Controllers;
using System;
using System.Windows.Forms;

namespace LogTagAutomationApp.Views
{
    public partial class ucSettings : UserControl
    {
        public ucSettings()
        {
            InitializeComponent();

            btnSettingsBack.Click += (sender, e) => VisibilityController.ShowUserControl("main");
            btnSettingsDefaultUsername.Click += SaveDefaultUsername;
            btnSettingsMasterOutput.Click += ChangeDefaultOutputFolder;
            btnSettingsUsername.Click += SaveCurrentUsername;
            VisibleChanged += InitializeSettings;
        }

        private void SaveCurrentUsername(object sender, EventArgs e)
        {
            MessageBox.Show(SessionController.SetUsername(textBoxSettingsCurrentUser.Text) ? "Current Username changed" : "Username too long");
        }

        private void SaveDefaultUsername(object sender, EventArgs e)
        {
            MessageBox.Show(FileController.SaveDefaultUsernameJson(textBoxSettingsDefaultUser.Text) ? "Default Username changed" : "Unable to change");
        }

        private void ChangeDefaultOutputFolder(object sender, EventArgs e)
        {
            MessageBox.Show(SessionController.SetDefaultTestFolder(textBoxSettingsMasterOutput.Text) ? "Path changed" : "Unable to change");
        }

        private void InitializeSettings(object sender, EventArgs e)
        {
            // Check if user control is becoming visible
            if (this.Visible)
            {
                textBoxSettingsCurrentUser.Text = SessionController.UserName;
                textBoxSettingsMasterOutput.Text = SessionController.MainOutputFolder;
            }
        }

        //private void SaveCurrentUsername(object? sender, EventArgs e)
        //{
        //    ShowMessage(SessionController.SetUsername(textBoxSettingsUsername.Text) ? "Current Username changed" : "Username too long");

        //}

        //private void SaveDefaultUsername(object? sender, EventArgs e)
        //{
        //    ShowMessage(FileController.SaveUsernameJson(textBoxSettingsDefaultUser.Text) ? "Default Username changed" : "Unable to change");
        //}

        //private void SaveOutput(object? sender, EventArgs e)
        //{
        //    SessionController.SetFilePath(textBoxFilePath.Text);
        //    ShowMessage("File output directory saved");
        //}

    }
}
