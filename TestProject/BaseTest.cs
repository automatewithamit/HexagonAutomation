using AventStack.ExtentReports;
using Framework;
using Framework.Helpers;
using Framework.Reporting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestFixture]
    public class BaseTest
    {
        ExtentReports extentReport;
       

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ExtentReport Report = new ExtentReport();
            extentReport = Report.CreateReport();          


        }
        

        [SetUp] //This gets executed before Test
        public void Setup()
        {
            string testMethodName = TestContext.CurrentContext.Test.Name;

            ExtentReport.Log = extentReport.CreateTest(testMethodName);

            ExtentReport.Log.Info("Setup");

            ExtentReport.Log.Info("Starting the CHROME Browser...");

            DriverManager.StartBrowser();
            string url = JSONHelper.GetValue("currentURL");
            //2. Navigate to the Website
            DriverManager.driver.Navigate().GoToUrl(url);

        }

        [TearDown]
        public void TearDown()
        {
            ExtentReport.Log.Info("Closing the Browser...");
            DriverManager.driver.Quit();
            ExtentReport.Log.Info("Tear down");
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            extentReport.Flush();
        }
    }
}
