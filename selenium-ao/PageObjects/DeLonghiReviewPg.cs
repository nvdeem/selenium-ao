using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_ao.PageObjects
{
    public class DeLonghiReviewPg
    {
        private IWebElement DeLonghiReviewTitle()
        {
            return WebDriver.Browser.FindElement(By.XPath("//h1[@id='pageTitle']"));
        }

        public bool DeLonghiReviewPageTitleDisplayed()
        {
            return DeLonghiReviewTitle().Displayed;
        }
    }
}
