using NUnit.Framework;
using PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestProject
{
    [TestFixture, Parallelizable]
    public class FlikartCartTest : BaseTest
    {

        [Test]
        public void VerifyFlipkartCartFunctionality()
        {
            //Open the Flipkart website
            string expectedEmptyCartMessage = "Missing Cart items?";

            Console.WriteLine("Starting to Verify Cart Button Functionality");
            // close the login dailog box
            FlipkartLoginPage_Old loginPage = new FlipkartLoginPage_Old();
            loginPage.closeLoginDailog();
            //click on cart
            FlipkartHomePage_Old homePage = new FlipkartHomePage_Old();
            homePage.clickCartButton();
            Console.WriteLine("Clicked Cart Button");
            //verify the 'Missing Cart items?'
            FlipkartCartPage_Old cartPage = new FlipkartCartPage_Old();
            string actualemptyCartMessage = cartPage.GetActualEmptyCartMessage();
            Assert.AreEqual(expectedEmptyCartMessage, actualemptyCartMessage);
            Thread.Sleep(5000);

        }
        

    }
}
