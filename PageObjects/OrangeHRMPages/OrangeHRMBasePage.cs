﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.OrangeHRMPages
{
    public class OrangeHRMBasePage
    {       

        public NavigationMenuPage navigateTo()
        {
            return new NavigationMenuPage();
        }


    }
}
