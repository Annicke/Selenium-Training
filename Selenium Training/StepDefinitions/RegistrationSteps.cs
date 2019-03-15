using NUnit.Framework;
using Selenium_Training.PageObjects;
using Selenium_Training.Utilities;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Selenium_Training.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage Registration;
            public RegistrationSteps()
        {
            Registration = new RegistrationPage();
        }

       [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks1.driver.Navigate().GoToUrl("https://giftrete.com");
            Hooks1.driver.Manage().Window.Maximize();
        }

        [Given(@"I have entered my first name")]
        public void GivenIHaveEnteredMyFirstName()
        {
            Registration.FirstName("Annick");
        }
        
        [Given(@"I have entered my last name")]
        public void GivenIHaveEnteredMyLastName()
        {
            Registration.LastName("Sibaveun");
        }
        
        [Given(@"I have entered my emailadress")]
        public void GivenIHaveEnteredMyEmailadress()
        {
            Registration.Email("sibaveun2016@gmail.com");
        }
        
        [Given(@"I entered my mobile n(.*)")]
        public void GivenIEnteredMyMobileN(int p0)
        {
            Registration.Mobile("07475553323");
        }
        
        [Given(@"I have entered my password")]
        public void GivenIHaveEnteredMyPassword()
        {
            Registration.Password("12345678");
        }
        
        [Given(@"I have confirm password")]
        public void GivenIHaveConfirmPassword()
        {
            Registration.Password("12345678");
        }
        
        [When(@"I click on Sign Up")]
        public void WhenIClickOnSignUp()
        {
            Registration.SignUp();
        }
        
        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
            Thread.Sleep(5000);
           Assert.IsTrue(Registration.SuccessMessageIsDisplayed());
        }
    }
}
