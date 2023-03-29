using Docker.DotNet.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Pages
{
    public class SearchPage
    {
        private IWebDriver driver;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
    
       }
        By SearchTextbox = By.XPath("//*[@name=\"search_query\"]");
        public ResultPage SearchText(string text)
        {
            driver.FindElement(SearchTextbox).SendKeys(text);
            driver.FindElement(SearchTextbox).SendKeys(Keys.Enter);
            return new ResultPage(driver);


        }
    }

}
