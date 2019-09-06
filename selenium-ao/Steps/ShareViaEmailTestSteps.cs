using NUnit.Framework;
using selenium_ao.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace selenium_ao
{
    [Binding]
    public class ShareViaEmailTestSteps
    {
        private readonly DeLonghiProductPg deLonghiProductPg = new DeLonghiProductPg();

        [Given(@"I click the share button")]
        public void GivenIClickTheShareButton()
        {
            deLonghiProductPg.ClickShareButton();
        }
        
        [When(@"I enter an email address")]
        public void WhenIEnterAnEmailAddress()
        {
            deLonghiProductPg.EnterEmailInShareWindow();
        }
        
        [When(@"I click the send product button")]
        public void WhenIClickTheSendProductButton()
        {
            deLonghiProductPg.ClickSendProduct();
        }
        
        [Then(@"the email product wwindow is displayed")]
        public void ThenTheEmailProductWwindowIsDisplayed()
        {
            Assert.IsTrue(deLonghiProductPg.ShareEmailWindowDisplayed());
        }
        
        [Then(@"the email will be sent")]
        public void ThenTheEmailWillBeSent()
        {
            deLonghiProductPg.EmailSentDisplayed();
        }
    }
}
