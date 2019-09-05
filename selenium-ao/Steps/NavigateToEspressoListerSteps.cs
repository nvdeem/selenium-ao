using NUnit.Framework;
using selenium_ao.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace selenium_ao.Steps
{
    [Binding]
    public class NavigateToEspressoListerSteps
    {
        private const string stackTraceDivider = "------------- Stack Trace -------------";
        private readonly SmallAppliancesPg smallAppliancesPg = new SmallAppliancesPg();
        private readonly CoffeeMachinesPg coffeeMachinesPg = new CoffeeMachinesPg();
        private readonly EspressoListerPg espressoListerPg = new EspressoListerPg();

        [Given(@"I am on the coffee machines page")]
        public void GivenIAmOnTheCoffeeMachinesPage()
        {
            try
            {
                smallAppliancesPg.ClickCoffeeBtn();
                Assert.IsTrue(smallAppliancesPg.CheckCoffeeMachinesBtn());
                Console.WriteLine("Assertion: Coffee Machines button exists/is functional.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Cannot assert on clicking Coffee Machines view all button." + Environment.NewLine +
                    stackTraceDivider + Environment.NewLine + e.StackTrace);
            }

            try
            {
                coffeeMachinesPg.ThenIAmOnTheCoffeeMachinesPg();
                Console.WriteLine("Assertion: On the Coffee Machines page.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Not able to assert that user is on Coffee Machines page." + Environment.NewLine +
                    stackTraceDivider + Environment.NewLine + e.StackTrace);
            } 
        }
        
        [When(@"I click the View All button on the Espresso card")]
        public void WhenIClickTheViewAllButtonOnTheEspressoCard()
        {
            try
            {
                coffeeMachinesPg.ClickEspressoBtn();
                Console.WriteLine("Assertion: Button is present and has been clicked.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Cannot assert Espresso view all button is functioning." + Environment.NewLine +
                    stackTraceDivider + Environment.NewLine + e.StackTrace);
            }
        }
        
        [Then(@"the Espresso machines lister page is displayed")]
        public void ThenTheEspressoMachinesListerPageIsDisplayed()
        {
            try
            {
                Thread.Sleep(2000);
                espressoListerPg.EspressoListerDisplayed();
                Console.WriteLine("Assertion: On the Espresso lister page");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Cannot assert that user is on Espresso lister page." + Environment.NewLine +
                    stackTraceDivider + Environment.NewLine + e.StackTrace);
            }
        }
    }
}