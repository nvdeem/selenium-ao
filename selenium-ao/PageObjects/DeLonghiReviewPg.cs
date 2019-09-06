using OpenQA.Selenium;

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
