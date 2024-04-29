using LogTagAutomationApp.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LogTagAutomationApp.Controllers
{
    internal class ListDisplay
    {
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string BatchNumber { get; set; }
        public string TesterName { get; set; }
        public string DateOfTest { get; set; }
        public bool Result { get; set; }
    }

    internal class SearchController
    {
        public static void Initialise() { }

        public static List<string> GetModelNames()
        {
            List<string> uniqueModelNames = new List<string>();

            // Iterate through each completed test
            foreach (var test in TestController.CompletedTests)
            {
                // Select distinct model names from loggers in the current test
                var modelsInTest = test.Loggers.Where(logger => logger.Model != null).Select(logger => logger.Model).Distinct();

                // Add the distinct model names to the list of unique model names
                foreach (var model in modelsInTest)
                {
                    if (!uniqueModelNames.Contains(model))
                    {
                        uniqueModelNames.Add(model);
                    }
                }
            }
            return uniqueModelNames;
        }

        public static List<Test> GetListOfTests(Search search)
        {
            var testList = TestController.CompletedTests.ToList(); // Ensure you're working with a copy of the list

            // Filter tests based on search criteria
            if (search.Result != null && search.Result != "All")
            {
                testList = testList.Where(test => test.Result.ToString().Equals(search.Result)).ToList();
            }

            if (search.Tester != null)
            {
                testList = testList.Where(test => test.TesterName.ToLower().Equals(search.Tester.ToLower())).ToList();
            }

            if (search.Date != null)
            {
                testList = testList.Where(test => test.DateOfTest.Equals(search.Date)).ToList();
            }

            return testList;
        }

        public static List<ListDisplay> GetListOfLoggers(List<Test> tests, Search search)
        {
            List<ListDisplay> loggers = new List<ListDisplay>();

            // Perform join operation between tests and loggers based on the test ID
            var query =
                from test in tests
                from logger in test.Loggers
                select new { Test = test, Logger = logger };

            // Filter the joined results based on the search criteria
            query = query.Where(item =>
                (search.Model == null || (item.Logger.Model != null && item.Logger.Model.Equals(search.Model))) &&
                (search.SerialNumber == null || (item.Logger.SerialNumber != null && item.Logger.SerialNumber.ToLower().Equals(search.SerialNumber.ToLower()))) &&
                (search.BatchNumber == null || (item.Logger.BatchNumber != null && item.Logger.BatchNumber.ToLower().Equals(search.BatchNumber.ToLower()))));

            // Create ListDisplay instances from the joined results
            foreach (var item in query)
            {
                loggers.Add(new ListDisplay
                {
                    Model = item.Logger.Model,
                    SerialNumber = item.Logger.SerialNumber,
                    BatchNumber = item.Logger.BatchNumber,
                    TesterName = item.Test.TesterName,
                    DateOfTest = item.Test.DateOfTest,
                    Result = item.Test.Result
                });
            }
            return loggers;
        }

    }
}
