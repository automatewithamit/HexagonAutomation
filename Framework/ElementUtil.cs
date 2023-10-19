using Framework.Reporting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class ElementUtil
    {
        public static void Click(By locator)
        {
            try
            {
                IWebElement element = DriverManager.driver.FindElement(locator);
                element.Click();
                ExtentReport.Log.Info("Clicking on Element --> " + locator.ToString());
            }
            catch (StaleElementReferenceException)
            {
                Thread.Sleep(5000);
                Click(locator);
            }
            catch (Exception e)
            {

                ExtentReport.Log.Info("Clicking on Element --> " + locator.ToString());
            }

        }
        public static void SetText(By locator, string text)
        {
            try
            {
                IWebElement element = DriverManager.driver.FindElement(locator);
                element.SendKeys(text);
                ExtentReport.Log.Info("Set Text '" + text + "' in Element --> " + locator.ToString());
            }
            catch (StaleElementReferenceException)
            {
                Thread.Sleep(5000);
                Click(locator);
            }
            catch (Exception e)
            {

                ExtentReport.Log.Info("Clicking on Element --> " + locator.ToString());
            }
        }
        public static Size GetSize(By locator)
        {
            var element = DriverManager.driver.FindElement(locator);
            return element.Size;
        }
        public static string GetText(By locator)
        {
            var element = DriverManager.driver.FindElement(locator);
            return element.Text;
        }
        //public void SetText(By locator, string text)
        //{
        //    try
        //    {
        //        IWebElement element = DriverManager.driver.FindElement(locator);
        //        element.SendKeys(text);
        //        ExtentReport.Log.Info("Set Text '" + text + "' in Element --> " + locator.ToString());
        //    }
        //    catch (StaleElementReferenceException)
        //    {
        //        Thread.Sleep(5000);
        //        Click(locator);
        //    }
        //    catch (Exception e)
        //    {

        //        ExtentReport.Log.Info("Clicking on Element --> " + locator.ToString());
        //    }
        //}
    }
}
