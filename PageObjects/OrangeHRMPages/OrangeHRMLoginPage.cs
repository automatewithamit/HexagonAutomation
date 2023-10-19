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
        TextBox userNameTextBox = new TextBox(By.XPath("//input[@name='username']"));
        TextBox passwordTextBox = new TextBox(By.XPath("//input[@name='password']"));
        Button loginButton = new Button(By.XPath("//button[@type='submit']"));
        Label loginErrorMessage = new Label(By.XPath("//p[contains(@class,'oxd-alert-content-text')]"));
        public void loginToOrangeHRM(string username, string password)
        {
            userNameTextBox.SetText(username);
            passwordTextBox.SetText(password);
            loginButton.Click();
        }
        public string GetLoginErrorMessage()
        {
            return loginErrorMessage.GetLabelText();
        }
    }
}
