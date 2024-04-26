using QualityAutomation.Controllers;
using System.Windows.Forms;

namespace LogTagAutomationApp.Views
{
    public partial class ucMain : UserControl
    {
        public ucMain()
        {
            InitializeComponent();

            // Event handlers for buttons
            btnMainGoTest.Click += ((sender, e) => VisibilityController.ShowUserControl("testCreate"));
            btnMainGoSearch.Click += ((sender, e) => VisibilityController.ShowUserControl("search"));
            btnMainGoSettings.Click += ((sender, e) => VisibilityController.ShowUserControl("settings"));
        }
    }
}
