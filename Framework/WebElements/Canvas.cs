using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.WebElements
{
    public class Canvas
    {
        public By Locator { get; set; }
        public Canvas(By locator)
        {
            this.Locator = locator;
        }
        public void GetCanvasData()
        {
            Size size = ElementUtil.GetSize(Locator);
            int height = size.Height / 2;
            int width = size.Width / 2;

            Actions builder = new Actions(DriverManager.driver);
            Thread.Sleep(5000);
            var element = DriverManager.driver.FindElement(Locator);
            
            ((IJavaScriptExecutor)DriverManager.driver).ExecuteScript("arguments[0].scrollIntoView();", element);
            builder.MoveToElement(element, size.Height/2, size.Width/2).Click().Perform();
        }

    }
}
