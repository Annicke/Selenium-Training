using System;
using TechTalk.SpecFlow;

namespace Selenium_Training.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I have entered my emailAddress")]
        public void GivenIHaveEnteredMyEmailAddress()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on Secure Sign In")]
        public void WhenIClickOnSecureSignIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be signed In")]
        public void ThenIShouldBeSignedIn()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
