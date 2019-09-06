using NUnit.Framework;
using selenium_ao.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace selenium_ao
{
    [Binding]
    public class NavigateToReviewPgTestSteps
    {
        private const string stackTraceDivider = "------------- Stack Trace -------------";
        private readonly EspressoListerPg espressoListerPg = new EspressoListerPg();
        private readonly DeLonghiReviewPg deLonghiReviewPg = new DeLonghiReviewPg();

        [When(@"I click on the reviews link")]
        public void WhenIClickOnTheReviewsLink()
        {
            try
            {
                espressoListerPg.ClickDeLonghiReviews();
                Console.WriteLine("Assertion: Reviews link has been clicked.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Cannot assert that the reviews link has been clicked." + Environment.NewLine +
                    stackTraceDivider + Environment.NewLine + e.StackTrace);
            }
        }

        [Then(@"the reviews page is displayed for the selected product")]
        public void ThenTheReviewsPageIsDisplayedForTheSelectedProduct()
        {
            try
            {
                Assert.IsTrue(deLonghiReviewPg.DeLonghiReviewPageTitleDisplayed());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Cannot assert that the DeLonghi reviews page is displayed." + Environment.NewLine +
                    stackTraceDivider + Environment.NewLine + e.StackTrace);
            }
        }
    }
}