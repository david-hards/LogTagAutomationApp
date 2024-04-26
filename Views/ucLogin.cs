using LogTagAutomationApp.Controllers;
using QualityAutomation.Controllers;
using System.Windows.Forms;

namespace LogTagAutomationApp.Views
{
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();

            // Event Handler for button
            btnLoginSubmit.Click += (sender, e) => SubmitLogin();
            textBoxLogin.KeyDown += (sender, e) => { if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; SubmitLogin(); } };
        }

        private void SubmitLogin()
        {
            if (SessionController.SetUsername(textBoxLogin.Text))
            {
                VisibilityController.ShowUserControl("main");
            }
        }
    }
}
