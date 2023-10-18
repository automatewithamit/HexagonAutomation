using Framework.WebElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.OrangeHRMPages
{
    public class OrangeHRMHeaderPage : OrangeHRMBasePage
    {
        Label TabNameText = new Label(By.XPath("//span[contains(@class,'header-breadcrumb')]"));

        public string GetCurrentTabName()
        {
            return TabNameText.GetLabelText();
        }

    }
}
