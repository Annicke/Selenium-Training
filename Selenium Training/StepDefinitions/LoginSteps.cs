using Selenium_Training.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace Selenium_Training.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        LoginPage Login;

        public LoginSteps()
        {
            Login = new LoginPage();
        }

        [Given(@"I have entered my emailAddress")]
        public void GivenIHaveEnteredMyEmailAddress()
        {
            Login.EnterEmail("sibaveun2016@gmail.com");
        }
        
        [When(@"I click on Secure Sign In")]
        public void WhenIClickOnSecureSignIn()
        {
           Login.ClickSecureSignIn();
        }
        
        [Then(@"I should be signed In")]
        public void ThenIShouldBeSignedIn()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
