using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Microsoft_test
{
    class MainMenuPageObject
    {
        private IWebDriver _driver;

        private readonly By _search = By.Id("welcome-page-search-form-autocomplete-input");
        private readonly By _next_page = By.ClassName("pagination-next");

        String result = "";

        public MainMenuPageObject(IWebDriver driver)
        {
            _driver = driver;
        }
  
        public bool Navigate_to_search()
        {
            bool check = true;

            _driver.FindElement(_search).SendKeys("LINQ" + OpenQA.Selenium.Keys.Enter);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    new WebDriverWait(_driver, TimeSpan.FromSeconds(2)).Until(ExpectedConditions.ElementToBeClickable(_next_page));
                    result = _driver.FindElement(By.XPath("//a[contains(@aria-describedby, 'description." + j + "')]")).Text;
                    check = Preference.Contains(result, "LINQ" , StringComparison.OrdinalIgnoreCase);
                    if (check)
                        continue;
                    else
                        return false;
                }

                _driver.FindElement(_next_page).Click();
            }  
            
            return true;
        }
          
    }
}
