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
            btnSettingsMasterOutput.Click += SaveOutput;
            btnSettingsUsername.Click += SaveCurrentUsername;
        }

        private void SaveCurrentUsername(object sender, EventArgs e)
        {
            //MessageBox.Show(SessionController.SetUsername(textBoxSettingsUsername.Text) ? "Current Username changed" : "Username too long");
        }

        private void SaveDefaultUsername(object sender, EventArgs e)
        {
            //MessageBox.Show(FileController.SaveUsernameJson(textBoxSettingsDefaultUser.Text) ? "Default Username changed" : "Unable to change");
        }

        private void SaveOutput(object sender, EventArgs e)
        {
            //SessionController.SetFilePath(textBoxFilePath.Text);
            MessageBox.Show("File output directory saved");
        }
    }
}
