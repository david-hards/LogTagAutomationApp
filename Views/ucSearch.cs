using QualityAutomation.Controllers;
using System.Windows.Forms;

namespace LogTagAutomationApp.Views
{
    public partial class ucSearch : UserControl
    {
        public ucSearch()
        {
            InitializeComponent();
            btnSearchBack.Click += (sender, e) => VisibilityController.ShowUserControl("main");
        }
    }
}
