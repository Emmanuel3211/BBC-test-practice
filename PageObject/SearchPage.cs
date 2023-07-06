using BBC_test_practice.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBC_test_practice.PageObject
{
    class SearchPage
    {
        public IWebDriver driver;
        private By searchMenu = By.XPath("//*[@id=\"header-content\"]/nav/div[1]/div/div[3]/div[2]/a");
        private By searchBar = By.XPath("//*[@id=\"search-input\"]");
        private By searchButton = By.XPath("(//*[@width='content-length'])[2]");


        public SearchPage()
        {
            driver = BaseTest.driver;
        }

        public void ClickSearchMenu()
        {
            driver.FindElement(searchMenu).Click();
        }

        public void TypeInSearcBar()
        { 
            driver.FindElement(searchBar).SendKeys("weather");
        }

        public void ClickSearchButton()
        {
            driver.FindElement(searchButton).Click();
        }




    }

}
