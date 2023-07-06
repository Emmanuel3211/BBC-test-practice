using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace BBC_test_practice.Hooks
{
    [Binding]
    public class BaseTest
    {
        public static IWebDriver driver;
       
        [BeforeScenario]
        public static void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
        
        
        [AfterScenario]
        public void AfterScenario()
        {
           //driver.Close();
        }
    }
}