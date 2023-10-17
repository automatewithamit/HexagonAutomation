using Framework;
using Framework.WebElements;
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
        Button cartButton = new Button(By.LinkText("Cart"));
        Button travelButton = new Button(By.XPath("//a[@aria-label='Travel']"));

        public void clickCartButton()
        {
            cartButton.Click();
        }
        public FlipkartTravelPage gotoTravelSection()
        {
            travelButton.Click();
            return new FlipkartTravelPage();
        }

    }
}
