﻿using Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class FlipkartHomePage 
    {
        IWebElement cartButton = DriverManager.driver.FindElement(By.LinkText("Cart"));
        IWebElement loginButton = DriverManager.driver.FindElement(By.LinkText("Cart"));

        public void clickCartButton()
        {
            cartButton.Click();
        }
        public void clickloginButton()
        {
            loginButton.Click();
        }

    }
}
