using NUnit.Framework;
using PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestFixture]
    public class FlipkartTravelBookingTest : BaseTest
    {

        [Test]
        public void BookTravel()
        {
            //1. launch url


            //2. close login dailog
            FlipkartLoginPage loginPage = new FlipkartLoginPage();
            loginPage.closeLoginDailog();
            FlipkartHomePage homePage = new FlipkartHomePage();

            //3. go to Travel
            homePage.gotoTravelSection().searchForFlights("HYD","BLR","","");




            //4. Book a ticket from HYD to DELHI
        }





    }
}
