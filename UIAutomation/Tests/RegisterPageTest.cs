using EbayAutomation.Pages;
using EbayAutomation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace EbayAutomation.Tests
{
    public class Tests: Base
    {
        public static RegisterPage registerPage = new RegisterPage(driver);
        public static SignIn signIn = new SignIn(driver);
        string actualTitle = "Register: Create a personal account";

        [Test]
        public void AssertPageTitle()
        {
            signIn.getCreateAccount().Click();
            Assert.AreEqual(registerPage.GetTitleRegisterPage(), actualTitle);
        }

        [Test]
        public void CreateAccount()
        {
            signIn.getCreateAccount().Click();
            registerPage.EnterAccountDetails("Test", "Testing", "Test@gmail.com", "Test@123");
        }

    }
}