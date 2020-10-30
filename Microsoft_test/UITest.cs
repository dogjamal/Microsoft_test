using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using RestSharp;

namespace Microsoft_test
{
    class UITest : BaseTest
    {
     
        [Test]
        public void Test_for_search()
        {

            var main_menu = new MainMenuPageObject(_driver);

           Assert.IsTrue(main_menu.Navigate_to_search());


        }
    }
}
