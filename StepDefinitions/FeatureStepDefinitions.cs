using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class FeatureStepDefinitions
    {
        private IWebDriver driver;
        
        public FeatureStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }


        [Given(@"open the browser")]
        public void GivenOpenTheBrowser()
        {
         //   driver = new ChromeDriver();
          //  driver.Manage().Window.Maximize();
        }
         
        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(5000);
        }

        [Then(@"Search for the Testers Talk")]
        public void ThenSearchForTheTestersTalk()
        {
            driver.FindElement(By.XPath("//*[@name=\"search_query\"]")).SendKeys("Tester Talk");
            driver.FindElement(By.XPath("//*[@name=\"search_query\"]")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
           // driver.Quit();
        }




    }
}