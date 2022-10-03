using EbayAutomation.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbayAutomation.Pages
{
    public class RegisterPage: Base
    {
        private IWebDriver driver;
        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #region Page Locators
        [FindsBy(How = How.XPath, Using = "//input[@id='firstname']")]
        private readonly IWebElement firstName;

        [FindsBy(How = How.Id, Using = "lastname")]
        private IWebElement lastName;

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement email;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password;

        [FindsBy(How = How.Id, Using = "EMAIL_REG_FORM_SUBMIT")]
        private IWebElement btnCreateAccount;
        #endregion

        #region Page Methods
        public IWebElement getFirstName()
        {
            return firstName;
        }
        public IWebElement getLastName()
        {
            return lastName;
        }
        public IWebElement getEmail()
        {
            return email;
        }
        public IWebElement getPassword()
        {
            return password;
        }
        public IWebElement clickCreateAccountBtn()
        {
            return btnCreateAccount;
        }
        public string GetTitleRegisterPage()
        {
            return driver.Title;
        }

        public void EnterAccountDetails(String fName, String lName, String eMail, String pass)
        {
            getFirstName().SendKeys(fName);
            Console.WriteLine(getFirstName());
            getLastName().SendKeys(lName);
            getEmail().SendKeys(eMail);
            getPassword().SendKeys(pass);
            clickCreateAccountBtn().Click();
        }
        #endregion


    }
}
