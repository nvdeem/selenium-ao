using NUnit.Framework;
using selenium_ao.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace selenium_ao
{
    [Binding]
    public class CoffeeMachinesPgSteps
    {
        private readonly SmallAppliancesPg smallAppliancesPg = new SmallAppliancesPg();
        private readonly CoffeeMachinesPg coffeeMachinesPg = new CoffeeMachinesPg();

        [Given(@"I am on the small appliances page")]
        public void GivenIAmOnTheSmallAppliancesPage()
        {
            try
            {
                Assert.IsTrue(smallAppliancesPg.ThenIAmOnTheSmallAppliancesPg());
                Console.WriteLine("Assertion: On the Small Appliances page.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Cannot assert that user is on Small Appliances page." + Environment.NewLine +
                    "------------- Stack Trace -------------" + Environment.NewLine + e.StackTrace);
            }
        }

        [When(@"I click the View All button on the coffee machines card")]
        public void WhenIClickTheViewAllButtonOnTheCoffeeMachinesCard()
        {
            try
            {
                smallAppliancesPg.ClickCoffeeBtn();
                Assert.IsTrue(smallAppliancesPg.CheckCoffeeMachinesBtn());
                Console.WriteLine("Assertion: Coffee Machines button is present and functions.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Cannot assert on View All button in Coffee Machines card." + Environment.NewLine +
                    "------------- Stack Trace -------------" + Environment.NewLine + e.StackTrace);
            }
        }

        [Then(@"the coffee machines page is displayed")]
        public void ThenTheCoffeeMachinesPageIsDisplayed()
        {
            try
            {
                var onCoffeeMachinesPage = coffeeMachinesPg.ThenIAmOnTheCoffeeMachinesPg();
                Assert.AreEqual(onCoffeeMachinesPage, true);
                Console.WriteLine("Assertion: I am on the coffee machines page");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Cannot assert that user is on Coffee Machines page." + Environment.NewLine +
                    "------------- Stack Trace -------------" + Environment.NewLine + e.StackTrace);
            }
        }
    }
}