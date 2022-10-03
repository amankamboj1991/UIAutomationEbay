using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using ICSharpCode.SharpZipLib.Zip;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace EbayAutomation.Utilities
{
    public class Base
    {
        public static IWebDriver driver;
        // Extent report implementation

        //ExtentReports extentReports;
        /*
        [OneTimeSetUp]
        public void ReportSetup()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            Console.WriteLine(projectDirectory);
            string reportPath = projectDirectory + "//index.html";
            var htmlReports = new ExtentHtmlReporter(reportPath);
            extentReports.AttachReporter(htmlReports);
        }
        */
        [SetUp]
        public void StartBrowser()
        {
            //extentReports.CreateTest(TestContext.CurrentContext.Test.Name);
            InitBrowser("Chrome");
            driver.Manage().Window.Maximize();
            driver.Url = "https://signin.ebay.com/ws/eBayISAPI.dll?SignIn&ru=https%3A%2F%2Fwww.ebay.com%2F";
        }

        public void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;

                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;

                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;
            }
        }

        [TearDown]
        public void AfterTest()
        {
            {
                driver.Quit();
            }
        }

    }
}
