using NUnit.Framework;
using selenium_ao.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace selenium_ao.Steps
{
    [Binding]
    public class DeLonghiProductPgTestSteps
    {
        private const string stackTraceDivider = "------------- Stack Trace -------------";
        private readonly DeLonghiProductPg deLonghiProductPg = new DeLonghiProductPg();
        private readonly SmallAppliancesPg smallAppliancesPg = new SmallAppliancesPg();
        private readonly CoffeeMachinesPg coffeeMachinesPg = new CoffeeMachinesPg();
        private readonly EspressoListerPg espressoListerPg = new EspressoListerPg();

        [Given(@"I am on the delonghi product page")]
        public void GivenIAmOnTheDelonghiProductPage()
        {
            try
            {
                smallAppliancesPg.ClickCoffeeBtn();
                coffeeMachinesPg.ClickEspressoBtn();
                espressoListerPg.ClickGridView();
                Thread.Sleep(2000);
                espressoListerPg.ClickMoreInfoDeLonghi();

                Thread.Sleep(2000);
                String URL = WebDriver.Browser.Url;
                Assert.That(URL.Contains("/product/ec685bk-delonghi-dedica"));
                Assert.IsTrue(deLonghiProductPg.DeLonghiProductNameDisplayed());
                Console.WriteLine("Assertion: DeLonghi EC685BK product page is displayed.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Cannot assert that user is on the DeLonghi product page." + Environment.NewLine +
                    stackTraceDivider + Environment.NewLine + e.StackTrace);
            }
        }

        [When(@"I click the choose colour lister")]
        public void WhenIClickTheChooseColourLister()
        {
            try
            {
                deLonghiProductPg.ClickColourDropdown();
                Assert.IsTrue(deLonghiProductPg.ColourPickerOpenDisplayed());
                Console.WriteLine("Assertion: Dropdown has been selected, colour options are displayed.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Cannot assert that the colour dropdown is displayed." + Environment.NewLine +
                    stackTraceDivider + Environment.NewLine + e.StackTrace);
            }
        }

        [When(@"I click the red option")]
        public void WhenIClickTheRedOption()
        {
            try
            {
                deLonghiProductPg.ClickRedOption();
                Console.WriteLine("Assertion: Red dropdown clicked.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Cannot assert that red has been selected." + Environment.NewLine +
                    stackTraceDivider + Environment.NewLine + e.StackTrace);
            }
        }

        [Then(@"the red version of the product is displayed")]
        public void ThenTheRedVersionOfTheProductIsDisplayed()
        {
            try
            {
                Thread.Sleep(2000);
                String redUrl = WebDriver.Browser.Url;
                Assert.AreEqual(redUrl, "https://beta-aol.ao-qa.com/product/ec685r-delonghi-dedica-traditional-pump-espresso-coffee-machine-red-51101-66.aspx");
                Console.WriteLine("Assertion: Red DeLonghi product is displayed.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Cannot assert that red version of the product page has been displayed." + Environment.NewLine +
                    stackTraceDivider + Environment.NewLine + e.StackTrace);
            }

        }
    }
}
