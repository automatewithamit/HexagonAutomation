using NUnit.Framework;
using PageObjects;
using System;
using System.Threading;

namespace TestProject
{
    [TestFixture, Parallelizable]
    public class FlipkartLoginTest : BaseTest
    {

        [Test]
        public void VerifyFlipkartLoginFunctionality()
        {

            string email = "abc@xyz.com";
            //launch Browser

            //navigate to flipkart

            //enter email
            FlipkartLoginPage_Old loginPage = new FlipkartLoginPage_Old();
            loginPage.closeAfterEnteringEmail(email);
            
            
            
            //click on login button
            //verify the error message
            //close the login dailog box 
            //close the browser

        }



    }
}