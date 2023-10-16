using Framework;
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

        //1.All the WebElements available on the page
        //2.Any Action we wanted to perform on the webElement


        //Locators --> we use locators to identify any web element on the webpage
        //1. name
        //2. id
        //3. class Name
        //4. XPATH
        //5. CSS Selector
        //6. TagName
        //7. Link Text
        //8. partial Link Text

        IWebElement cartButton = DriverManager.driver.FindElement(By.LinkText("Cart"));

        public void clickCartButton()
        {
            cartButton.Click();
        }


    }
}
