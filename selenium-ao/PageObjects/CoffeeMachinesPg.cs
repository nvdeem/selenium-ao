using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_ao.PageObjects
{
    public class CoffeeMachinesPg
    {
        /* Elements */

        //-- Coffee Machines heading
        private IWebElement CoffeeTitle()
        {
            return WebDriver.Browser.FindElement(By.XPath("//div[@id='categorySignPost']//h1[normalize-space(.) = 'Coffee Machines']"));
        }

        //-- Espresso Button
        private IWebElement EspressoBtn()
        {
            return WebDriver.Browser.FindElement(By.XPath("//a[starts-with(@href, '/l/espresso_coffee_machines/1/55-63-66/')]"));
        }

        /* Checks */
        public bool ThenIAmOnTheCoffeeMachinesPg()
        {
            return CoffeeTitle().Displayed;
        }

        public bool EspressoBtnIsDisplayed()
        {
            return EspressoBtn().Displayed;
        }

        /* Actions */
        public void ClickEspressoBtn()
        {
            WebDriver.Browser.FindElement(By.XPath("//a[starts-with(@href, '/l/espresso_coffee_machines/1/55-63-66/')]")).Click();
        }
    }
}