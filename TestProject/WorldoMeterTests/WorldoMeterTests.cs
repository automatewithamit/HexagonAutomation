using NUnit.Framework;
using PageObjects.WorldoMeterPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.WorldoMeterTests
{
    [TestFixture]
    public class WorldoMeterTests : BaseTest
    {
        [Test]
        public void worldometerSVGGraphTest()
        {
            WorldoMeterHomePage homePage = new WorldoMeterHomePage();
            homePage.GetSVGData();


            
        }

        
    }
}
