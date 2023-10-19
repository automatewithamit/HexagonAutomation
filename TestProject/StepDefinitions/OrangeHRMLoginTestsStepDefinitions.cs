using NUnit.Framework;
using PageObjects.OrangeHRMPages;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace TestProject.StepDefinitions
{
    [Binding]
    public class OrangeHRMLoginTestsStepDefinitions
    {
        //Scenario Context is used to share values across the step definitions
        private ScenarioContext _scenarioContext;

        public OrangeHRMLoginTestsStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"User is logged in using credentials")]
        public void GivenUserIsLoggedInUsingCredentials(Table table)
        {
            OrangeHRMLoginPage loginPage = new OrangeHRMLoginPage();
            var rows = table.Rows[1]["username"];
            
            loginPage.loginToOrangeHRM(table.Rows[0]["username"], table.Rows[0]["password"]);
           
            _scenarioContext["name"] = "AutomateWithAmit";
            Console.WriteLine("Added Value name in Scenario Context");

        }

        [Given(@"Clicks on Admin Tab")]
        public void GivenClicksOnAdminTab()
        {
            var _name = _scenarioContext["name"];
            Console.WriteLine(_name);
            OrangeHRMDashboardPage dashboardPage = new OrangeHRMDashboardPage();
            dashboardPage.navigateTo().adminMenu();            

        }

        [Then(@"Verify Admin page is displayed with ""([^""]*)"" name")]
        public void ThenVerifyAdminPageIsDisplayedWithName(string expectedTabName)
        {
            GivenClicksOnAdminTab();
            OrangeHRMHeaderPage headerPage = new OrangeHRMHeaderPage();
            string currentTabName = headerPage.GetCurrentTabName();

            Assert.IsTrue(currentTabName.Contains(expectedTabName));
        }


        [Given(@"User is logged in using credentials (.*) and (.*)")]
        public void GivenUserIsLoggedInUsingCredentialsAdminAndAdmin(string username, string password)
        {
            OrangeHRMLoginPage loginPage = new OrangeHRMLoginPage();
            loginPage.loginToOrangeHRM(username, password);
        }

        [Given(@"User should get (.*) message")]
        public void GivenUserShouldGetInvalidCredentialsMessage(string expectedMessage)
        {
            OrangeHRMLoginPage loginPage = new OrangeHRMLoginPage();
            string actualErrorMessage = loginPage.GetLoginErrorMessage();
            Assert.AreEqual(expectedMessage,actualErrorMessage);
        }


    }
}
