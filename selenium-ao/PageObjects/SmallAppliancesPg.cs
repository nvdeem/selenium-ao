using OpenQA.Selenium;
using System.Threading;

namespace selenium_ao.PageObjects
{
    public class SmallAppliancesPg
    {
        /* Elements */

        // Small Appliances heading
        private IWebElement MainTitle()
        {
            return WebDriver.Browser.FindElement(By.XPath("//h1[text()='Small Appliances']"));
        }

        // View All button in the Coffee Machines card
        private IWebElement CoffeeMachinesBtn()
        {
            return WebDriver.Browser.FindElement(By.XPath("//a[starts-with(@href, '/small-appliances/coffee-machines')]"));
        }

        private IWebElement FoodPrepBtn()
        {
            return WebDriver.Browser.FindElement(By.XPath("//a[starts-with(@href, '/small-appliances/food-preparation')]"));
        }

        /* Checks */
        public bool ThenIAmOnTheSmallAppliancesPg()
        {
            return MainTitle().Displayed;
        }

        public bool CheckCoffeeMachinesBtn()
        {
            return CoffeeMachinesBtn().Displayed;
        }

        public bool CheckFoodPrepBtn()
        {
            return FoodPrepBtn().Displayed;
        }

        /* Actions */
        public void ClickCoffeeBtn()
        {
            WebDriver.Browser.FindElement(By.XPath("//a[starts-with(@href, '/small-appliances/coffee-machines')]")).Click();
        }
    }
}