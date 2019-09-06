using NUnit.Framework;
using selenium_ao.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace selenium_ao.Steps
{
    [Binding]
    public class EspressoListerPgTestsSteps
    {
        private const string stackTraceDivider = "------------- Stack Trace -------------";
        private readonly SmallAppliancesPg smallAppliancesPg = new SmallAppliancesPg();
        private readonly CoffeeMachinesPg coffeeMachinesPg = new CoffeeMachinesPg();
        private readonly EspressoListerPg espressoListerPg = new EspressoListerPg();
        private readonly DeLonghiProductPg deLonghiProductPg = new DeLonghiProductPg();

        [Given(@"I am on the espresso machines lister page")]
        public void GivenIAmOnTheEspressoMachinesListerPage()
        {
            Thread.Sleep(2000);
            smallAppliancesPg.ClickCoffeeBtn();
            Thread.Sleep(2000);
            coffeeMachinesPg.ClickEspressoBtn();

            try
            {
                espressoListerPg.EspressoListerDisplayed();
                Assert.IsTrue(espressoListerPg.EspressoListerDisplayed());
                Console.WriteLine("Assertion: On the Espresso lister page");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Cannot assert that user is on Espresso lister page." + Environment.NewLine +
                    stackTraceDivider + Environment.NewLine + e.StackTrace);
            }
        }

        [Given(@"I have changed the view to grid view")]
        public void GivenIHaveChangedTheViewToGridView()
        {
            try
            {
                Thread.Sleep(2000);
                espressoListerPg.ClickGridView();
                Console.WriteLine("Assertion: Grid view has been toggled.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Cannot assert that Grid view has been clicked." + Environment.NewLine +
                     stackTraceDivider + Environment.NewLine + e.StackTrace);
            }
        }

        [When(@"I click the more info button")]
        public void WhenIClickTheMoreInfoButton()
        {
            Thread.Sleep(1000);
            espressoListerPg.ClickMoreInfoDeLonghi();
        }

        [Then(@"the delonghi item product page is displayed")]
        public void ThenTheDelonghiItemProductPageIsDisplayed()
        {
            try
            {
                deLonghiProductPg.DeLonghiProductNameDisplayed();
                Assert.IsTrue(deLonghiProductPg.DeLonghiProductNameDisplayed());
                Console.WriteLine("Assertion: On the DeLonghi product page");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Cannot assert that the DeLonghi product page is displayed." + Environment.NewLine +
                     stackTraceDivider + Environment.NewLine + e.StackTrace);
            }
        }
    }
}