using NUnit.Framework;
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
            OrangeHRMDashboardPage dashboardPage = new OrangeHRMDashboardPage();
            dashboardPage.navigateTo().adminMenu();

        }

        [Then(@"Verify Admin page is displayed with ""([^""]*)"" name")]
        public void ThenVerifyAdminPageIsDisplayedWithName(string expectedTabName)
        {
            OrangeHRMHeaderPage headerPage = new OrangeHRMHeaderPage();
            string currentTabName = headerPage.GetCurrentTabName();
            
            Assert.AreEqual(expectedTabName, currentTabName);
        }


       
        

    }
}
