using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace QA_Automation_SauceDemo
{
    public class ThankYouPage
    {
        IWebDriver driver;

        public ThankYouPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement ThankYouMessage => driver.FindElement(By.CssSelector(".complete-header"));

        public string GetThankYouMessage()
        {
            return ThankYouMessage.Text;
        }
    }
}
