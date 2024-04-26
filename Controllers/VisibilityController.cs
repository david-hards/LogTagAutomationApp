using System.Collections.Generic;
using System.Windows.Forms;

namespace QualityAutomation.Controllers
{
    public static class VisibilityController
    {
        private static readonly Dictionary<string, UserControl> userControlPanels = new Dictionary<string, UserControl>();
        public static IReadOnlyDictionary<string, UserControl> UserControlPanels => userControlPanels;


        // Add user control panels to the dictionary
        public static void AddUserControl(string key, UserControl userControl)
        {
            userControlPanels.Add(key, userControl);
        }

        // Show a specific user control panel and hide others
        public static void ShowUserControl(string key)
        {
            foreach (var pair in userControlPanels)
            {
                if (pair.Key == key)
                {
                    pair.Value.Visible = true;
                }
                else
                {
                    pair.Value.Visible = false;
                }
            }
        }

        public static void HideAll()
        {
            foreach (var pair in UserControlPanels)
            {
                pair.Value.Visible = false;
            }
        }
    }
}