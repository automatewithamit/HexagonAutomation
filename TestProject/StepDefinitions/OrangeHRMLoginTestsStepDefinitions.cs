using PageObjects.OrangeHRMPages;
using System;
using TechTalk.SpecFlow;

namespace TestProject.StepDefinitions
{
    [Binding]
    public class OrangeHRMLoginTestsStepDefinitions
    {
        [Given(@"User is logged in using credentials ""([^""]*)"" and ""([^""]*)""")]
        public void GivenUserIsLoggedInUsingCredentials(string username, string password)
        {
            OrangeHRMLoginPage loginPage = new OrangeHRMLoginPage();
            loginPage.loginToOrangeHRM(username, password);
        }

        [Given(@"Clicks on Admin Tab")]
        public void GivenClicksOnAdminTab()
        {
            
        }

        [Then(@"Verify Admin page is displayed")]
        public void ThenVerifyAdminPageIsDisplayed()
        {
            
        }
    }
}
