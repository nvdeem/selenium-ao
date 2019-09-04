using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_ao.PageObjects
{
    public class EspressoListerPg
    {
        /* Elements */
        
        //--  Espresso title
        private IWebElement EspressoListerTitle()
        {
            return WebDriver.Browser.FindElement(By.XPath("//h1[normalize-space(.) = 'Espresso Coffee Machines']"));
        }

        //-- DeLonghi - More Info Button
        private IWebElement DeLonghiMoreInfoBtn()
        {
            return WebDriver.Browser.FindElement(By.XPath("//a[starts-with(@href, '/product/ec685bk-delonghi-dedica-traditional-pump-espresso-coffee-machine-black-51597-66.aspx')]"));
        }

        //-- Silver Facet
        private IWebElement ColourFilterSteel()
        {
            return WebDriver.Browser.FindElement(By.XPath("//li[@id='fv_stainless20steel']"));
        }

        /* Checks */
        public bool EspressoListerDisplayed()
        {
            return EspressoListerTitle().Displayed;
        }

        public bool FilterSteelDisplayed()
        {
            return ColourFilterSteel().Displayed;
        }

        /* Actions */
        public void ClickAndExpandDeLonghiItem()
        {
            WebDriver.Browser.FindElement(By.XPath("//*[@id='moreLink']")).Click();
        }

        public void ClickGridView()
        {
            WebDriver.Browser.FindElement(By.XPath("//label[@class='viewRadio']//*[@class='icon-grid']")).Click();
        }

        public void ClickMoreInfoDeLonghi()
        {
            WebDriver.Browser.FindElement(By.XPath("//a[@class='product-page-link primaryButton moreInfo']")).Click();
        }

        public void ToggleColourFilterSteel()
        {
            WebDriver.Browser.FindElement(By.XPath("//li[@id='fv_stainless20steel']")).Click();
        }
    }
}