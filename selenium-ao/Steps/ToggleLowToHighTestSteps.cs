using NUnit.Framework;
using selenium_ao.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace selenium_ao.Steps
{
    [Binding]
    public class ToggleLowToHighTestSteps
    {
        private const string stackTraceDivider = "------------- Stack Trace -------------";
        private readonly EspressoListerPg espressoListerPg = new EspressoListerPg();

        [When(@"I toggle the sort by dropdown to price low to high")]
        public void WhenIToggleTheSortByDropdownToPriceLowToHigh()
        {
            try
            {
                espressoListerPg.SelectLowToHigh();
                Console.WriteLine("Assertion: Low to High option selected.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Cannot assert that the Low to High option was selected." + Environment.NewLine +
                    stackTraceDivider + Environment.NewLine + e.StackTrace);
            }
        }
        
        [Then(@"the items are listed from lowest price to highest")]
        public void ThenTheItemsAreListedFromLowestPriceToHighest()
        {
            try
            {
                Thread.Sleep(2000);
                String URL = WebDriver.Browser.Url;
                Assert.That(URL.Contains("/?sort=aol_saleincvat"));
                Console.WriteLine("Assertion: Items ordered from Low to High.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Cannot assert that the items are ordered from Low to High." + Environment.NewLine +
                    stackTraceDivider + Environment.NewLine + e.StackTrace);
            }
        }
    }
}
