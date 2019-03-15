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
    class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Hooks1.driver, this);
        }

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement email { get; set; }

        public void EnterEmail(string Email)
        {
            email.SendKeys(Email);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='password']")]
        private IWebElement password { get; set; }

        public void EnterPassword(string Password)
        {
           password.SendKeys(Password);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='login-form']/div[4]/button")]
        private IWebElement secureSignIn{ get; set; }

        public void ClickSecureSignIn ()
        {
            secureSignIn.Click();
        }

    }
}
