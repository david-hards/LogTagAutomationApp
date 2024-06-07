using LogTagAutomationApp.Controllers;
using LogTagAutomationApp.Models;
using QualityAutomation.Controllers;
using System;
using System.Collections.Generic;
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
            btnTestResultFinish.Click += WipeScreen;
            dataGridViewResults.RowHeadersVisible = false;

        }

        // Method to display test results in a DataGridView
        public static void DisplayTestResults(List<MatchedLogger> matchedLoggers, Test test)
        {
            if (test == null || matchedLoggers == null || matchedLoggers.Count == 0)
            {
                Debug.WriteLine("Invalid test or matchedLoggers list.");
                return;
            }

            // Clear existing columns and rows
            grid.Columns.Clear();
            grid.Rows.Clear();

            // Add column for Dostmann temperatures
            grid.Columns.Add("Dostmann", "Dostmann");

            // Add columns for each logger and their variance
            foreach (MatchedLogger logger in matchedLoggers)
            {
                grid.Columns.Add(logger.Serial, logger.Serial);
                grid.Columns.Add($"{logger.Serial}-var", $"Variance ({logger.Serial})");
            }

            // Iterate through each logger
            foreach (MatchedLogger logger in matchedLoggers)
            {
                Debug.WriteLine($"Writing for {logger.Model}, serial: {logger.Serial}");
                // Iterate through each MatchedReading for the current logger
                foreach (MatchedReading reading in logger.MatchedReadings)
                {
                    // Add a new row for each MatchedReading
                    int rowIndex = grid.Rows.Add();
                    Debug.WriteLine($"Writing row {rowIndex}");
                    // Set ValueFromDostmann from the first logger
                    if (logger == matchedLoggers[0])
                    {
                        grid.Rows[rowIndex].Cells["Dostmann"].Value = reading.ValueFromDostmann;
                    }
                    // Set ValueFromLogger for the current logger
                    grid.Rows[rowIndex].Cells[logger.Serial].Value = reading.ValueFromLogger;
                    // Calculate and set variance for the current logger
                    double variance = reading.ValueFromDostmann - reading.ValueFromLogger;
                    grid.Rows[rowIndex].Cells[$"{logger.Serial}-var"].Value = variance;

                    // Check Temperature variance at set points 
                    if(reading.ValueFromLogger < -20 && variance > 0.7)
                    {
                        test.Result = false;
                    }
                    else if (reading.ValueFromLogger > 40 && variance > 0.7)
                    {
                        test.Result = false;
                    }
                    else if (variance > 0.5)
                    {
                        test.Result = false;
                    }
                }
            }

            // Resize columns to fit content
            grid.AutoResizeColumns();

            // Set AutoSizeColumnsMode to Fill to make columns fill the width of the DataGridView
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Show the DataGridView
            grid.Visible = true;

            VisibilityController.ShowUserControl("testResult");
        }

        private void WipeScreen(object sender, EventArgs e)
        {
            grid.Columns.Clear();
            grid.Rows.Clear();
            VisibilityController.ShowUserControl("main");
        }

    }

}

