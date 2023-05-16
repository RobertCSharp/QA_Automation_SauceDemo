using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace QA_Automation_SauceDemo
{
    public class CartPage
    {
        IWebDriver driver;

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement CheckOutButton => driver.FindElement(By.CssSelector("#checkout"));

        public void ClickCheckOut()
        {
            CheckOutButton.Click();
        }
    }
}
