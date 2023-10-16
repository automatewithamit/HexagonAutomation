using Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{

    public class FlipkartLoginPage : ElementUtil
    {
        //a[@title='Cart' and contains(@href , 'viewcart')][1]
        //a[@title='Cart' and text()='Cart']
        By byCloseButton = By.XPath("//span[@role='button']");
        By byEmailOrMobile = By.XPath("//label[text()='Enter Email/Mobile number']/../input");


        public void closeLoginDailog()
        {
            Click(byCloseButton);
            Console.WriteLine("Clicking on Close Button..");
        }
        public void closeAfterEnteringEmail(string email)
        {
            Thread.Sleep(10000);
            SetText(byEmailOrMobile, email);
            
            Thread.Sleep(3000);
            Click(byCloseButton);
            Console.WriteLine("Clicking on Close Button..");

        }

    }
}
