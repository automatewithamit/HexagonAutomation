using Framework;
using Framework.Helpers;
using System;
using TechTalk.SpecFlow;

namespace TestProject
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Setup");

            Console.WriteLine("Starting the CHROME Browser...");

            DriverManager.StartBrowser();
            string url = JSONHelper.GetValue("currentURL");
            //2. Navigate to the Website
            DriverManager.driver.Navigate().GoToUrl(url);
        }

        

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Closing the Browser...");
            DriverManager.driver.Quit();
            Console.WriteLine("Tear down");
        }
    }
}