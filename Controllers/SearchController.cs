using LogTagAutomationApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogTagAutomationApp.Controllers
{
    internal class SearchController
    {
        // List of Tests that match the parameters of a search
        public static List<Test> SearchResults { get; set; } = new List<Test>();

        public void SearchViaSerialNumber(string serial)
        {

        }

        public static List<string> GetModelNames()
        {
            List<string> uniqueModelNames = new List<string>();
            Debug.WriteLine($"uniquemodelnames is {uniqueModelNames}");
            Debug.WriteLine($"uniquemodelnames count is {uniqueModelNames.Count}");

            // Iterate through each completed test
            foreach (var test in TestController.CompletedTests)
            {
                Debug.WriteLine($"test done {test.DateOfTest} by {test.TesterName} with result {test.Result}");

                // Select distinct model names from loggers in the current test
                var modelsInTest = test.Loggers.Select(logger => logger.Model).Distinct();

                // Add the distinct model names to the list of unique model names
                uniqueModelNames.AddRange(modelsInTest);
                Debug.WriteLine($"uniquemodelnames count is {uniqueModelNames.Count}");

                foreach(var l in test.Loggers)
                {
                    Debug.WriteLine($"logger model is {l.Model}");
                }
            }

            Debug.WriteLine($"FINAL COUNT of uniqueloggernames count is {uniqueModelNames.Count}");


            // Return the list of unique model names
            return uniqueModelNames;
        }

        public void SearchViaModelName(string model)
        {
            model = model.ToUpper();
        }

        public void SearchViaBatchNumber(string batchNumber)
        {

        }

        public void SearchViaTesterName(string testerName)
        {
            
        }

        public void SearchViaDate(string date)
        {

        }

        public void SearchViaResult(bool result)
        {

        }

        public void ClearSearchResults()
        {
            SearchResults.Clear();
        }

    }
}
