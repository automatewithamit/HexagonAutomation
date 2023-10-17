﻿using Framework;
using Framework.WebElements;
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

        Button closeButton = new Button(By.XPath("//span[@role='button']"));
        TextBox emailOrMobileTextbox = new TextBox(By.XPath("//label[text()='Enter Email/Mobile number']/../input"));

        //By byCloseButton = By.XPath("//span[@role='button']");
        //By byEmailOrMobile = By.XPath("//label[text()='Enter Email/Mobile number']/../input");


        public void closeLoginDailog()
        {
            //Click(byCloseButton);
            closeButton.Click();
            Console.WriteLine("Clicking on Close Button..");            
        }
        public void closeAfterEnteringEmail(string email)
        {
            Thread.Sleep(10000);
            emailOrMobileTextbox.SetText(email);
            
            Thread.Sleep(3000);
            closeButton.Click();
            Console.WriteLine("Clicking on Close Button..");

        }

    }
}
