using NUnit.Framework;
using selenium_ao.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace selenium_ao
{
    [Binding]
    public class ToggleFacetToSteelTestSteps
    {
        private const string stackTraceDivider = "------------- Stack Trace -------------";
        private readonly EspressoListerPg espressoListerPg = new EspressoListerPg();

        [When(@"I click the stainless steel facet")]
        public void WhenIClickTheStainlessSteelFacet()
        {
            try
            {
                Assert.IsTrue(espressoListerPg.FilterSteelDisplayed());
                Console.WriteLine("Assertion: Steel filter is displayed.");
                espressoListerPg.ToggleColourFilterSteel();
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Cannot assert on clicking the Stainless Steel facet." + Environment.NewLine +
                    stackTraceDivider + Environment.NewLine + e.StackTrace);
            }
        }

        [Then(@"only the stainless steel products are displayed")]
        public void ThenOnlyTheStainlessSteelProductsAreDisplayed()
        {
            try
            {
                String URL = WebDriver.Browser.Url;
                Assert.AreEqual(URL, "https://beta-aol.ao-qa.com/l/espresso_coffee_machines-stainless_steel/1-17/55-63-66/");
                Console.WriteLine("Assertion: Only the stainless steel espresso machines are displayed.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Cannot assert that the Stainless Steel products are displayed." + Environment.NewLine +
                    stackTraceDivider + Environment.NewLine + e.StackTrace);
            }
        }
    }
}