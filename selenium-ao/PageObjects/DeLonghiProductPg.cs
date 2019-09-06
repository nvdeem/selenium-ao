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

        private IWebElement ShareEmailWindow()
        {
            return WebDriver.Browser.FindElement(By.XPath("//div[@class='emailShare']"));
        }

        private IWebElement EmailSent()
        {
            return WebDriver.Browser.FindElement(By.XPath("//strong[@class='sendFinished']"));
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

        public bool ShareEmailWindowDisplayed()
        {
            return ShareEmailWindow().Displayed;
        }

        public bool EmailSentDisplayed()
        {
            return EmailSent().Displayed;
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

        public void ClickShareButton()
        {
            WebDriver.Browser.FindElement(By.XPath("//a[@class='shareProduct icon-share ctaButton']")).Click();
        }

        public void ClickSendProduct()
        {
            WebDriver.Browser.FindElement(By.XPath("//div[@class='emailShare']//a[@id='emailSendButton']")).Click();
        }

        public void EnterEmailInShareWindow()
        {
            WebDriver.Browser.FindElement(By.XPath("//div[@class='emailShare']//input[@id='shareInput']")).SendKeys("keke@dot-coin.com");
        }
    }
}
