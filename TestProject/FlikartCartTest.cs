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
            Console.WriteLine("Starting to Verify Cart Button Functionality");
            FlipkartLoginPage loginPage = new FlipkartLoginPage();


            loginPage.closeLoginDailog();

            FlipkartHomePage homePage = new FlipkartHomePage();


            homePage.clickCartButton();
            Console.WriteLine("Clicked Cart Button");

            Thread.Sleep(5000);
            Assert.Pass();
        }

    }
}
