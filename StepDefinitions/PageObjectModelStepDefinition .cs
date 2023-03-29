using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class PageObjectModelStepDefinitions
    {
        private IWebDriver driver;
        
        public PageObjectModelStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Enter the youtube URL")]
        public void GivenEnterTheYoutubeURL()
        {
            
        }

        [When(@"Search for the testers talk in youtube")]
        public void WhenSearchForTheTestersTalkInYoutube()
        {
            
        }

        [When(@"Navigate to channel")]
        public void WhenNavigateToChannel()
        {
            
        }

        [Then(@"Verify title of the page")]
        public void ThenVerifyTitleOfThePage()
        {
            
        }




    }



}

        
       
          




   