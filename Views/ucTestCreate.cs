using LogTagAutomationApp.Controllers;
using QualityAutomation.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogTagAutomationApp.Views
{
    public partial class ucTestCreate : UserControl
    {
        private const string PlaceholderText = "Enter Batch number";

        public ucTestCreate()
        {
            InitializeComponent();
            // Set up custom components related to Logger testing
            SetupCustomComponents();
        }

        private void SetupCustomComponents()
        {
            // Add Event Handlers for Drag and Drop
            this.listBoxLTD.DragDrop += new DragEventHandler(listBoxLTD_DragDrop);
            this.listBoxLTD.DragEnter += new DragEventHandler(boxDragEnter);
            this.listBoxDostmann.DragDrop += new DragEventHandler(listBoxDostmann_DragDrop);
            this.listBoxDostmann.DragEnter += new DragEventHandler(boxDragEnter);

            // Add Event Handlers for Delete button press
            listBoxLTD.KeyUp += PressDelete;
            listBoxDostmann.KeyUp += PressDelete;

            // Add event handler for buttons
            btnTestCreate.Click += SubmitToTest;
            btnTestClearDostmann.Click += ClearDostmannListbox;
            btnTestClearLTD.Click += ClearLTDListbox;
            btnCreateTestBack.Click += (sender, e) => VisibilityController.ShowUserControl("main");

            // Combo box Event handler and Population
            comboBoxLoggers.SelectedIndexChanged += ComboBoxSelectionChanged;
            PopulateComboBox();

            // Text box Event Handler and Population
            textBoxBatchNumber.Text = PlaceholderText;
            textBoxBatchNumber.ForeColor = SystemColors.GrayText;
            textBoxBatchNumber.Enter += TextBox_Enter;
            textBoxBatchNumber.Leave += TextBox_Leave;
        }

        private void PopulateComboBox()
        {
            // Clear existing items
            comboBoxLoggers.Items.Clear();

            LoggerController.LoadLoggerProfilesFromFile();

            // Add logger objects to ComboBox
            foreach (var logger in LoggerController.LoggerProfiles)
            {
                comboBoxLoggers.Items.Add(logger);
                comboBoxLoggers.DisplayMember = "Model"; // Can be changed to display a mix of other info if required
            }
        }

        #region Drag and Drop Event Handlers

        private void listBoxLTD_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            // Check if total files exceed the limit
            if ((listBoxLTD.Items.Count + files.Length) > 6)
            {
                MessageBox.Show("Maximum of six files!");
                return;
            }

            // Check all files are LTD files
            if (files.Any(file => Path.GetExtension(file).ToLower() != ".ltd"))
            {
                MessageBox.Show("Only files with extension '.ltd' are allowed!");
                return;
            }

            // Add dropped files to the listboxLTD
            listBoxLTD.Items.AddRange(files);
        }

        private void listBoxDostmann_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Check if listBoxDostmann already contains an item
            if (listBoxDostmann.Items.Count > 0 || files.Length > 1)
            {
                // Display alert to the user
                MessageBox.Show("Maximum of one file!");
                return;
            }

            // Check if the dropped file has the extension ".dbf"
            string fileExtension = Path.GetExtension(files[0]);
            if (fileExtension.ToLower() != ".dbf")
            {
                // Display alert to the user
                MessageBox.Show("Only files extension '.dbf' is allowed!");
                return;
            }

            // Add the dropped file to listBoxDostmann
            listBoxDostmann.Items.AddRange(files);
        }

        private void boxDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
        }

        #endregion

        #region Button press Event Handlers

        private void ClearDostmannListbox(object sender, EventArgs e)
        {
            listBoxDostmann.Items.Clear();
        }

        private void ClearLTDListbox(object sender, EventArgs e)
        {
            listBoxLTD.Items.Clear();
        }

        private void PressDelete(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                // Remove the selected item from listboxDostmann
                if (listBoxDostmann.SelectedIndex != -1)
                {
                    listBoxDostmann.Items.RemoveAt(listBoxDostmann.SelectedIndex);
                }
                // Remove the selected item from listboxLTD
                if (listBoxLTD.SelectedIndex != -1)
                {
                    listBoxLTD.Items.RemoveAt(listBoxLTD.SelectedIndex);
                }
                // Unselect items from both list boxes
                listBoxDostmann.SelectedIndex = -1;
                listBoxLTD.SelectedIndex = -1;
            }
        }

        #endregion

        #region TextBox functionality

        private void TextBox_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text and change color to black
            if (textBoxBatchNumber.Text == PlaceholderText)
            {
                textBoxBatchNumber.Text = "";
                textBoxBatchNumber.ForeColor = SystemColors.WindowText;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            // Restore placeholder text if the textbox is empty
            if (string.IsNullOrWhiteSpace(textBoxBatchNumber.Text))
            {
                textBoxBatchNumber.Text = PlaceholderText;
                textBoxBatchNumber.ForeColor = SystemColors.GrayText;
            }
        }

        #endregion


        private void SubmitToTest(object sender, EventArgs e)
        {
            // Run checks to see if file info is valid
            if (listBoxDostmann.Items.Count != 1 || listBoxLTD.Items.Count < 1)
            {
                MessageBox.Show("There must be exactly one .dbf file selected\nThere must be at least one .ltd file selected");
                return;
            }
            if (comboBoxLoggers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Logger type from the menu");
                return;
            }
            if (textBoxBatchNumber.Text.Length > 30)
            {
                MessageBox.Show("Batch number cannot be longer than 30 characters");
                return;
            }


            // Try to submit test to TestController
            try
            {
                // Set Dostmann file path
                FileController.DostmannPath = listBoxDostmann.Items.Count > 0 ? listBoxDostmann.Items[0].ToString() : null;
                //Debug.WriteLine($"TESTING : Dostmann path set to {FileController.DostmannPath}");
                // Set LTD file paths
                FileController.LTDPaths = listBoxLTD.Items.Cast<string>().ToArray();

                TestController.NumOfLoggers = listBoxLTD.Items.Count;
                TestController.BatchNumber = textBoxBatchNumber.Text;
                TestController.CreateTest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Test submitted");
        }

        private void ComboBoxSelectionChanged(object sender, EventArgs e)
        {
            if (comboBoxLoggers.SelectedItem != null)
            {
                // Modify current Session info
                SessionController.CurrentSelectedLogger.Model = comboBoxLoggers.SelectedItem.ToString();
            }
        }
    }
}
