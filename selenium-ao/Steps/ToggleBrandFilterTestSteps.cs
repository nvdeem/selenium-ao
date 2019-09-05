using NUnit.Framework;
using selenium_ao.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace selenium_ao
{
    [Binding]
    public class ToggleBrandFilterTestSteps
    {
        private const string stackTraceDivider = "------------- Stack Trace -------------";
        private readonly EspressoListerPg espressoListerPg = new EspressoListerPg();

        [When(@"I check the brand filter check box for sage")]
        public void WhenICheckTheBrandFilterCheckBoxForSage()
        {
            try
            {
                espressoListerPg.ClickSageCheckBox();
                Console.WriteLine("Assertion: Sage checkbox is ticked.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Cannot assert that Sage checkbox is ticked." + Environment.NewLine +
                    stackTraceDivider + Environment.NewLine + e.StackTrace);
            }
        }
        
        [Then(@"only the sage products are displayed")]
        public void ThenOnlyTheSageProductsAreDisplayed()
        {
            try
            {
                String URL = WebDriver.Browser.Url;
                Assert.That(URL.Contains("/l/espresso_coffee_machines-sage"));
                Console.WriteLine("Assertion: Only Sage products are displayed.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Cannot assert that only Sage products are displayed." + Environment.NewLine +
                    stackTraceDivider + Environment.NewLine + e.StackTrace);
            }
        }
    }
}
