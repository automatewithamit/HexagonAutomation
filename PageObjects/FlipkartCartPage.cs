using Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class FlipkartCartPage
    {
        IWebElement missingCartText = DriverManager.driver.FindElement(By.XPath("//div[text()='Missing Cart items?']"));

        public string GetActualEmptyCartMessage()
        {
            return missingCartText.Text;
        }
        //span[contains(text(),'Please enter valid Email ID/Mobile number')]

    }
}
