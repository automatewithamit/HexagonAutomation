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
    public class SVG
    {
        public By Locator { get; set; }
        public SVG(By locator)
        {
            this.Locator = locator;
        }
        public List<string> GetData()
        {
            var elements = DriverManager.driver.FindElements(Locator);
            List<string> dataList = new List<string>();

            Actions builder = new Actions(DriverManager.driver);

            
            foreach(var element in elements)
            {
                builder.MoveToElement(element).Perform();
                dataList.Add(element.Text);
                Console.WriteLine(element.Text);
            }
            return dataList;
        }
        

    }
}
