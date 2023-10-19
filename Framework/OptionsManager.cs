using Framework.Helpers;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class OptionsManager
    {

        public static ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            if (Convert.ToBoolean(JSONHelper.GetValue("headless")))
            {
                option.AddArgument("--headless");
            }
            return option;
        }
    }
}
