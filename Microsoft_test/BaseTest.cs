using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RestSharp;

namespace Microsoft_test
{
    class BaseTest
    {
        protected IWebDriver _driver;

        [OneTimeSetUp]
        protected void Do_before_all_tests()
        {
            _driver = new ChromeDriver();
        }

        [OneTimeTearDown]
        protected void Do_after_all_tests()
        {

        }

        [TearDown]
        protected void Do_after_each()
        {
            _driver.Quit();
        }

        [SetUp]

        protected void Do_before_each()
        {
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Navigate().GoToUrl(TestSettings.Host_prefix);
        }

    }
}
