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
            FlipkartLoginPage_Old loginPage = new FlipkartLoginPage_Old();
            loginPage.closeLoginDailog();


            //3. go to Travel


            //4. Book a ticket from HYD to DELHI
        }





    }
}
