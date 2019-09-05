using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        
        // Espresso title
        private IWebElement EspressoListerTitle()
        {
            return WebDriver.Browser.FindElement(By.XPath("//h1[normalize-space(.) = 'Espresso Coffee Machines']"));
        }

        // DeLonghi - More Info Button
        private IWebElement DeLonghiMoreInfoBtn()
        {
            return WebDriver.Browser.FindElement(By.XPath("//a[starts-with(@href, '/product/ec685bk-delonghi-dedica-traditional-pump-espresso-coffee-machine-black-51597-66.aspx')]"));
        }

        // Silver Facet
        private IWebElement ColourFilterSteel()
        {
            return WebDriver.Browser.FindElement(By.XPath("//li[@id='fv_stainless20steel']"));
        }

        // Sort by dropdown
        private IWebElement SortByDropDown()
        {
            return WebDriver.Browser.FindElement(By.XPath("//select[@id='ddlSortBy']"));
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

        public bool SortByDropDownDisplayed()
        {
            return SortByDropDown().Displayed;
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

        public void ToggleSortByDropDown()
        {
            WebDriver.Browser.FindElement(By.CssSelector("#ddlSortBy")).Click();
        }

        public void SelectLowToHigh()
        {
            var lowToHigh = WebDriver.Browser.FindElement(By.XPath("//div[@id='productListerPage']//select[@id='ddlSortBy']"));
            var selectElement = new SelectElement(lowToHigh);
            selectElement.SelectByText("Price: Low to High");
        }

        public void ClickSageCheckBox()
        {
            WebDriver.Browser.FindElement(By.XPath("//li[@id='fv_sage']//a[@class='filter-facet__list-item-value navlink ']")).Click();
        }
    }
}