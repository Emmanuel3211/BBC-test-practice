using BBC_test_practice.Hooks;
using BBC_test_practice.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BBC_test_practice.StepDefinitions
{
    [Binding]
    public class SearchStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        SearchPage searchpage = new SearchPage();
        [Given(@"I navigate to bbc website")]
        public void GivenINavigateToBbcWebsite()
        {
            driver.Navigate().GoToUrl(@"https://www.bbc.co.uk/");
        }

        [Given(@"I click on the search menu")]
        public void GivenIClickOnTheSearchMenu()
        {
           searchpage.ClickSearchMenu();
        }

        [Given(@"I entered '([^']*)' in the search bar")]
        public void GivenIEnteredInTheSearchBar(string weather)
        {
            searchpage.TypeInSearcBar();
        }

        [When(@"I clicked the search button")]
        public void WhenIClickedTheSearchButton()
        {
            searchpage.ClickSearchButton();
        }

        [Then(@"weather information is displayed")]
        public void ThenWeatherInformationIsDisplayed()
        {
            
        }
    }
}
