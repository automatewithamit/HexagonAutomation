using Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    
    public class FlipkartLoginPage
    {
        IWebElement closeButton = DriverManager.driver.FindElement(By.XPath("/html/body/div[3]/div/span"));


        public void closeLoginDailog()
        {
            closeButton.Click();
        }
    }
}
