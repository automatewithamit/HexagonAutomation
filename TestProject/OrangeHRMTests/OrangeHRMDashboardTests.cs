﻿using NUnit.Framework;
using PageObjects.OrangeHRMPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.OrangeHRMTests
{
    [TestFixture]
    public class OrangeHRMDashboardTests : BaseTest
    {
        [Test]
        public void automateCanvasFromOrangeHRM()
        {
            OrangeHRMLoginPage loginPage = new OrangeHRMLoginPage();
            loginPage.loginToOrangeHRM("Admin", "admin123");
            OrangeHRMDashboardPage dashboardPage = new OrangeHRMDashboardPage();
            dashboardPage.GetCanvasData();
        }

    }
}
