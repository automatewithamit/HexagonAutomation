using Framework;
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
        [SetUp] //This gets executed before Test
        public void Setup()
        {
            DriverManager manager = new DriverManager();
            Console.WriteLine("Setup");

            Console.WriteLine("Starting the CHROME Browser...");
            //1. To Start the Browser
            DriverManager.driver = new ChromeDriver();
            //Implicit waits are always applied one time to the driver instance
            DriverManager.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            DriverManager.driver.Manage().Window.Maximize();

            //2. Navigate to the Website
            DriverManager.driver.Navigate().GoToUrl("https://www.flipkart.com/");

        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Closing the Browser...");
            DriverManager.driver.Quit();
            Console.WriteLine("Tear down");
        }
    }
}
