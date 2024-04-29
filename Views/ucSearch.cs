using LogTagAutomationApp.Controllers;
using LogTagAutomationApp.Models;
using QualityAutomation.Controllers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LogTagAutomationApp.Views
{

    //btnSearchSubmit.Click += (sender, e) => OpenSpecifiedFolder(SessionController.MainOutputFolder); // Open Folder Location 


    public partial class ucSearch : UserControl
    {
        public ucSearch()
        {
            InitializeComponent();
            btnSearchBack.Click += (sender, e) => VisibilityController.ShowUserControl("main");
            btnSearchSubmit.Click += SearchForTest;
            btnSearchClearAll.Click += ClearAll;
            this.VisibleChanged += ucSearchWindowOpened;
            dtPickerSearchDate.ShowCheckBox = true;
            dataGridViewSearchResults.RowHeadersVisible = false;
            dataGridViewSearchResults.CellFormatting += dataGridViewSearchResults_CellFormatting;
            dataGridViewSearchResults.CellDoubleClick += DataGridViewSearchResults_CellDoubleClick;

        }

        private void ucSearchWindowOpened(object sender, EventArgs e)
        {
            // Check if the UserControl is being made visible
            if (this.Visible && comboBoxSearchResult.Items.Count == 0)
            {
                // Populate combo boxes when the UserControl becomes visible
                comboBoxSearchResult.Items.AddRange(new object[] { "True", "False", "All" });
                comboBoxSearchResult.SelectedItem = "True";

                comboBoxSearchModel.Enter += comboBoxSearchModel_Enter;
                ClearAll(sender, e);
            }
        }

        private void comboBoxSearchModel_Enter(object sender, EventArgs e)
        {
            // Populate model names when the combo box receives focus
            List<string> modelNames = SearchController.GetModelNames();
            modelNames.Insert(0, ""); // Add null option at the top in case model does not want to be included in search
            comboBoxSearchModel.DataSource = modelNames;
            comboBoxSearchModel.Refresh();
        }

        private void SearchForTest(object sender, EventArgs e)
        {
            Search search = new Search();

            // Check if an item is selected in the ComboBox and if it's not null
            if (comboBoxSearchModel.SelectedItem != null)
            {
                // If NOT the top/pseudo-null value in the Combo Box
                if (!comboBoxSearchModel.SelectedItem.Equals(""))
                {
                    // Add Model as a Search parameter
                    search.Model = comboBoxSearchModel.SelectedItem.ToString();
                }
            }

            if (textBoxSearchSerial.Text != "")
            {
                search.SerialNumber = textBoxSearchSerial.Text;
            }

            if (textBoxSearchBatch.Text != "")
            {
                search.BatchNumber = textBoxSearchBatch.Text;
            }

            if (textBoxSearchTester.Text != "")
            {
                search.Tester = textBoxSearchTester.Text;
            }

            if (dtPickerSearchDate.Checked && dtPickerSearchDate.Value != DateTime.MinValue)
            {
                search.Date = dtPickerSearchDate.Value.ToString("yyyy-MM-dd");
            }

            search.Result = comboBoxSearchResult.Text;

            List<Test> tests = SearchController.GetListOfTests(search);
            List<ListDisplay> loggers = SearchController.GetListOfLoggers(tests, search);

            DisplaySearchResults(loggers);
        }


        private void OpenSpecifiedFolder(string model, string date)
        {
            var filePath = Path.Combine(SessionController.MainOutputFolder, date, model);
            // Specify the folder path you want to open
            Debug.WriteLine(filePath);

            // Check if the folder exists before attempting to open it
            if (System.IO.Directory.Exists(filePath))
            {
                // Open the folder using Process.Start
                Process.Start(filePath);
            }
            else
            {
                MessageBox.Show("Folder does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewSearchResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSearchResults.Rows[e.RowIndex];

                string model = row.Cells["Model"].Value.ToString();
                string date = row.Cells["DateOfTest"].Value.ToString();

                // Call the method with model and date as arguments
                OpenSpecifiedFolder(model, date);
            }
        }

        public void ClearAll(object sender, EventArgs e)
        {
            // Clear text boxes
            textBoxSearchSerial.Text = "";
            textBoxSearchBatch.Text = "";
            textBoxSearchTester.Text = "";

            // Clear date picker
            dtPickerSearchDate.Value = DateTime.Now; // Assuming you want to set it to the current date

            // Reset combo box selection if it has items
            if (comboBoxSearchModel.Items.Count > 0)
            {
                comboBoxSearchModel.SelectedIndex = 0; // Assuming the first item is the default (blank) option
            }

            // Reset combo box result selection
            comboBoxSearchResult.SelectedIndex = 0;

            // Clear DataGridView
            dataGridViewSearchResults.DataSource = null;
        }


        private void DisplaySearchResults(List<ListDisplay> loggers)
        {
            // Clear existing data in DataGridView
            dataGridViewSearchResults.DataSource = null;

            // Set the DataSource property to your list of loggers
            dataGridViewSearchResults.DataSource = loggers;

            // Resize columns to fit content
            dataGridViewSearchResults.AutoResizeColumns();
        }

        private void dataGridViewSearchResults_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if it's a data cell
            {
                DataGridViewCell cell = dataGridViewSearchResults.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Assuming the "Result" column index is known, replace it with the actual index
                int resultColumnIndex = 5; // For example, if the "Result" column is the 5th column

                if (e.ColumnIndex == resultColumnIndex) // Check if it's the "Result" column
                {
                    bool result = (bool)dataGridViewSearchResults.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    // Change background color for failed results to a subtle red
                    if (!result)
                    {
                        cell.Style.BackColor = System.Drawing.Color.FromArgb(255, 200, 200); // Subtle red
                    }
                }
            }
        }
    }
}

