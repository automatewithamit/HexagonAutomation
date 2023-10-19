using Framework.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class DriverManager
    {
        [ThreadStatic]
        public static IWebDriver driver;


        public static void StartBrowser()
        {
            string browserType = JSONHelper.GetValue("browserType");
            bool isRemote = Convert.ToBoolean(JSONHelper.GetValue("runOnRemote"));

            switch (browserType.ToLower())
            {
                case "chrome":
                    //1. To Start the Browser
                    if (isRemote)
                    {
                        DriverManager.driver = new RemoteWebDriver(new Uri("https://localhost:4445/wd/hub"), OptionsManager.GetChromeOptions());
                    }
                    else
                    {
                        DriverManager.driver = new ChromeDriver((ChromeOptions)OptionsManager.GetChromeOptions().ToCapabilities());
                    }
                    break;
                case "firefox":
                    //1. To Start the Browser
                    DriverManager.driver = new FirefoxDriver();
                    break;
                case "edge":
                    //1. To Start the Browser
                    if (isRemote)
                    {
                        DriverManager.driver = new RemoteWebDriver(new Uri("https://localhost:4445/wd/hub"), OptionsManager.GetEdgeOptions().ToCapabilities());
                    }
                    else
                    {
                        DriverManager.driver = new EdgeDriver();
                    }
                    break;
            }

            //Implicit waits are always applied one time to the driver instance
            DriverManager.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            DriverManager.driver.Manage().Window.Maximize();
        }



        //public IWebDriver StartRemoteWebDriver(string browser)
        //{
        //    // Define the capabilities for the desired browser (e.g., Chrome, Firefox)
        //    DesiredCapabilities capabilities = new DesiredCapabilities();
        //    capabilities.SetCapability(CapabilityType.BrowserName, browser);

        //    // URL of the Selenium Grid Hub
        //    Uri gridUrl = new Uri("http://<GRID-HUB-IP>:<PORT>/wd/hub");

        //    // Create and return the RemoteWebDriver instance
        //    return new RemoteWebDriver(gridUrl, capabilities);
        //}

        //public void StartRemoteWebDriver()
        //{
        //    DesiredCapabilities capabilities = new DesiredCapabilities();

        //}



    }
}
