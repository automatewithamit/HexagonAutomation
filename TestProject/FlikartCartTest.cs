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
    [TestFixture]
    public class FlikartCartTest : BaseTest
    {

        [Test]
        public void VerifyFlipkartCartFunctionality()
        {
            //Open the Flipkart website
            string expectedEmptyCartMessage = "Missing Cart items?";

            Console.WriteLine("Starting to Verify Cart Button Functionality");
            // close the login dailog box
            FlipkartLoginPage loginPage = new FlipkartLoginPage();
            loginPage.closeLoginDailog();
            //click on cart
            FlipkartHomePage homePage = new FlipkartHomePage();
            homePage.clickCartButton();
            Console.WriteLine("Clicked Cart Button");
            //verify the 'Missing Cart items?'
            FlipkartCartPage cartPage = new FlipkartCartPage();
            string actualemptyCartMessage = cartPage.GetActualEmptyCartMessage();
            Assert.AreEqual(expectedEmptyCartMessage, actualemptyCartMessage);
            Thread.Sleep(5000);

        }
        

    }
}
