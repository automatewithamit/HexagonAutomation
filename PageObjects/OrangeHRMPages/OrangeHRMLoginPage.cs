using Framework.WebElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.OrangeHRMPages
{
    public class OrangeHRMLoginPage : BasePage
    {
        TextBox userNameTextBox = new TextBox(By.XPath("//input[@placeholder='Username']"));
        TextBox passwordTextBox = new TextBox(By.XPath("//input[@placeholder='Password']"));
        Button loginButton = new Button(By.XPath("//button[@type='submit']"));
        public void loginToOrangeHRM(string username,string password)
        {
            userNameTextBox.SetText(username);
            passwordTextBox.SetText(password);
            loginButton.Click();
        }
    }
}
