using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium_Training.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Training.PageObjects
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            PageFactory.InitElements(Hooks1.driver, this);
        }
        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement register { get; set; }

        public void Register()
        {
            register.Click();
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='first_name']")]
        private IWebElement firstName { get; set; }

        public void FirstName(string FirstName)
        {
            firstName.SendKeys(FirstName);
        }

        [FindsBy(How = How.Id, Using = "last_name")]
        private IWebElement lastName { get; set; }

        public void LastName(string LastName)
        {
           lastName.SendKeys(LastName);
        }

        [FindsBy(How = How.CssSelector, Using = "#email")]
        private IWebElement email { get; set; }

        public void Email(string Email)
        {
            email.SendKeys(Email);
        }

        [FindsBy(How = How.Id, Using = "mobile")]
        private IWebElement mobile { get; set; }

        public void Mobile(string Mobile)
        {
            mobile.SendKeys(Mobile);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='password']")]
        private IWebElement password { get; set; }

        public void Password(string Password)
        {
            password.SendKeys(Password);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='confirm_password]")]
        private IWebElement confirmPassword { get; set; }

        public void ConfirmPassword(string Password)
        {
            confirmPassword.SendKeys(Password);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='signup - form']/div[9]/button")]
        private IWebElement signUp { get; set; }

        public void SignUp()
        {
            signUp.Click();
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='login-form']/div[1]")]
        private IWebElement successMessageIsDisplayed { get; set; }

        public bool SuccessMessageIsDisplayed()
        {
            try
            {
                return successMessageIsDisplayed.Displayed;
            }

            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
