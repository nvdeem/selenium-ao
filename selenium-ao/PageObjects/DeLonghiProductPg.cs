using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace selenium_ao.PageObjects
{
    class DeLonghiProductPg
    {
        /* Elements */

        private IWebElement DeLonghiProductName()
        {
            return WebDriver.Browser.FindElement(By.XPath("//h1[@class='title']"));
        }

        private IWebElement ColourPickerOpen()
        {
            return WebDriver.Browser.FindElement(By.XPath("//ul[@class='colour-options-list disable-scrolling reveal open']"));
        }

        /* Checks */

        public bool DeLonghiProductNameDisplayed()
        {
            return DeLonghiProductName().Displayed;
        }

        public bool ColourPickerOpenDisplayed()
        {
            return ColourPickerOpen().Displayed;
        }

        /* Actions */

        public void ClickColourDropdown()
        {
            WebDriver.Browser.FindElement(By.XPath("//li[@class='swatch base-black swatch-black']")).Click();
        }

        public void ClickRedOption()
        {
            WebDriver.Browser.FindElement(By.XPath("//li[@class='swatch base-red swatch-red']")).Click();
        }

        public void ToggleRed()
        {
            var red = WebDriver.Browser.FindElement(By.XPath("//li[@class='swatch base-red swatch-red']"));
            var selectElement = new SelectElement(red);
            selectElement.SelectByText("Red");
        }
    }
}
