using EbayAutomation.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbayAutomation.Pages
{
    public class SignIn: Base
    {
        private IWebDriver driver;
        public SignIn(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How =How.Id, Using = "create-account-link")]
        private readonly IWebElement createAccount;

        public IWebElement getCreateAccount()
        {
          return createAccount;
        }

        public string GetTitle()
        {
            return driver.Title;
        }
        public void ClickSignIn()
        {
            getCreateAccount().Click();
        }
    }
}
