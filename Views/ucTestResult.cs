using LogTagAutomationApp.Controllers;
using LogTagAutomationApp.Models;
using QualityAutomation.Controllers;
using System.Diagnostics;
using System.Windows.Forms;

namespace LogTagAutomationApp.Views
{
    public partial class ucTestResult : UserControl
    {
        private static DataGridView grid;

        public ucTestResult()
        {
            InitializeComponent();

            grid = dataGridViewResults;

            btnTestResultBack.Click += (sender, e) => VisibilityController.ShowUserControl("main");
            dataGridViewResults.RowHeadersVisible = false;

        }

        public static void DisplayTestResults(Test test)
        {
            Debug.WriteLine($"ucTestResult.DisplayTestResults: count is {TestController.NumOfLoggers}");
            if (test == null)
            {
                return;
            }

            for (int i = 0; i < test.Loggers.Count; i++)
            {
                //grid.Columns.Add($"column{i}", $"column{i}");

                grid.Columns.Add($"{test.Loggers[i].SerialNumber}", $"{test.Loggers[i].SerialNumber}");
                grid.Columns.Add($"{test.Loggers[i].SerialNumber}-var", $"Variance");
            }

            // Use this to fill in the data
            //CompareDostmannWithLTD.GenerateResults();

            /*
             *  Loggers will have a range of temps at 10 degree diff.
             *  Need the same for dostmann
             * 
             * 
             */
        }
    }
}
