using EbayAutomation.Pages;
using EbayAutomation.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbayAutomation.Tests
{
    public  class SignInTest: Base
    {
        public static SignIn signInPage = new SignIn(driver);
        String actualTitle = "Sign in or Register | eBay";

        [Test]
        public void AssertTitle()
        {
            Assert.AreEqual(signInPage.GetTitle(), actualTitle);
        }
    }

}
