using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace QA_Automation_SauceDemo
{
    public class ProductInfoPage
    {
        IWebDriver driver;

        public ProductInfoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement FnishButton => driver.FindElement(By.CssSelector("#finish"));

        public void ClickFinish()
        {
            FnishButton.Click();
        }
    }
}
