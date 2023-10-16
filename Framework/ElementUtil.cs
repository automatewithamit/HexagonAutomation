using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class ElementUtil
    {
        public void Click(By locator)
        {
            DriverManager.driver.FindElement(locator);
        }
    }
}
