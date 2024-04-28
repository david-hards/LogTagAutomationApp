using LogTagAutomationApp.Controllers;
using QualityAutomation.Controllers;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace LogTagAutomationApp.Views
{
    public partial class ucSearch : UserControl
    {
        private enum RESULT
        {
            True,
            False
        }

        public ucSearch()
        {
            InitializeComponent();
            btnSearchBack.Click += (sender, e) => VisibilityController.ShowUserControl("main");
            btnSearchSubmit.Click += SearchForTest;
            //btnSearchSubmit.Click += (sender, e) => OpenSpecifiedFolder(SessionController.MainOutputFolder); // Open Folder Location
            //comboBoxSearchResult.DataSource = Enum.GetValues(typeof(RESULT));
            //Debug.WriteLine($"calling populate combo box");
            //comboBoxSearchModel.DataSource = SearchController.GetModelNames();
            this.VisibleChanged += ucSearch_VisibleChanged;
        }

        private void ucSearch_VisibleChanged(object sender, EventArgs e)
        {
            // Check if the UserControl is being made visible
            if (this.Visible)
            {
                // Populate combo boxes only on the first load when the UserControl becomes visible
                comboBoxSearchResult.DataSource = Enum.GetValues(typeof(RESULT));
                comboBoxSearchModel.DataSource = SearchController.GetModelNames();
            }
        }

        private void SearchForTest(object sender, EventArgs e)
        {
            bool thing = true;
            var testsByTester = TestController.CompletedTests.Where(test => test.Result == thing);
            foreach ( var t in testsByTester)
            {
                Debug.WriteLine($"SEARCH RESULT: tested on {t.DateOfTest} by {t.TesterName}. Result was {t.Result}");
            }
        }

        private void OpenSpecifiedFolder(string path)
        {
            // Specify the folder path you want to open
            string folderPath = path;

            // Check if the folder exists before attempting to open it
            if (System.IO.Directory.Exists(folderPath))
            {
                // Open the folder using Process.Start
                Process.Start(folderPath);
            }
            else
            {
                MessageBox.Show("Folder does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

