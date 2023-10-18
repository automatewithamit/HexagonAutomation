using Framework.WebElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.OrangeHRMPages
{
    public class NavigationMenuPage
    {
        Button adminMenuButton = new Button(By.XPath("//a[contains(@href,'viewAdminModule')]"));

        public void navigateToAdminMenu()
        {
            adminMenuButton.Click();

        }

    }
}
