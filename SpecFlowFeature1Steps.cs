using selenium_ao.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace selenium_ao
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        public Steps steps = new Steps();
        public SmallAppliancesPg SmallAppliancesPage = new SmallAppliancesPg();

        [Given(@"I am on the Small Appliances page")]
        public void GivenIAmOnTheSmallAppliancesPage()
        {
            WebDriver.Initialise();
        }
        
        [When(@"I click the Coffee Machines button")]
        public void WhenIClickTheCoffeeMachinesButton()
        {
            //SmallAppliancesPage coffeeMachinesBtn.Click();
            //SmallAppliancesPage.
        }
        
        [Then(@"I will see the Coffee Machines page")]
        public void ThenIWillSeeTheCoffeeMachinesPage()
        {
            steps.ThenIAmOnTheCoffeeMachinesPg();
        }
    }
}
