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
        //a[@title='Cart' and contains(@href , 'viewcart')][1]
        //a[@title='Cart' and text()='Cart']
        IWebElement closeButton = DriverManager.driver.FindElement(By.XPath("//span[@role='button']"));
        IWebElement emailOrMobile = DriverManager.driver.FindElement(By.XPath("//input[@class='_2IX_2- VJZDxU']"));


        public void closeLoginDailog()
        {
            closeButton.Click();
            Console.WriteLine("Clicking on Close Button..");
        }
        public void closeAfterEnteringEmail(string email)
        {
            Thread.Sleep(10000);
            emailOrMobile.SendKeys(email);
            Console.WriteLine("Set Email with " + email);
            Thread.Sleep(3000);
            closeButton.Click();
            Console.WriteLine("Clicking on Close Button..");
            
        }

    }
}
