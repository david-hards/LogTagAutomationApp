using LogTagAutomationApp.Controllers;
using LogTagAutomationApp.Models;
using QualityAutomation.Controllers;
using System.Diagnostics;
using System.Runtime;
using System.Windows.Forms;

namespace LogTagAutomationApp.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Initialise my custom components
            SetupCustomComponents();

            // Load logger profiles and previous tests
            //Debug.WriteLine($"Calling FC.LoadDefaultSettings");
            FileController.LoadDefaultSettings();
            //Debug.WriteLine($"Calling FC.LoadPreviousTests");
            TestController.LoadPreviousTests();

            //////////////////////////////////////////////////////////////////////////////// Delete after testing
            //if (TestController.CompletedTests != null)
            //{
            //    foreach (Test t in TestController.CompletedTests)
            //    {
            //        Debug.WriteLine($"Tested on {t.DateOfTest} by {t.TesterName}. Result was {t.Result}");
            //    }
            //}
        }

        private void SetupCustomComponents()
        {
            // Add User Control pages for Visibility Handler
            VisibilityController.AddUserControl("login", ucLogin1);
            VisibilityController.AddUserControl("testCreate", ucTestCreate1);
            VisibilityController.AddUserControl("settings", ucSettings1);
            VisibilityController.AddUserControl("search", ucSearch1);
            VisibilityController.AddUserControl("main", ucMain1);
            VisibilityController.AddUserControl("testResult", ucTestResult1);

            // Hide all user control panels initially
            VisibilityController.HideAll();
            // Show main panel
            VisibilityController.ShowUserControl("login");
        }
    }
}
