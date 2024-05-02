using LogTagAutomationApp.Models;
using System.Windows.Forms;

namespace LogTagAutomationApp.Controllers
{
    public class SessionController
    {
        // The logger that is currently selected as the Test type
        public static Logger CurrentSelectedLogger { get; set; } = new Logger();
        // Stores the value of the current User
        public static string UserName { get; private set; }
        // Stores the file location of the resultsMasterFile.json test records
        public static string TestsMasterFile { get; set; }
        // Stores the file location of the folder to output to tests into
        public static string MainOutputFolder { get; set; }


        public static bool SetUsername(string username)
        {
            if (username.Length > 30 || username.Length < 3)
            {
                MessageBox.Show("Username must be between 3 and 30 characters");
                return false;
            }
            UserName = username;
            return true;
        }

        public static bool SetDefaultTestFolder(string path)
        {
            if (FileController.SetDefaultTestFolder(path))
            {
                MainOutputFolder = path;
                return true;
            };
            return false;

        }

    }
}
