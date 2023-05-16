using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace QA_Automation_SauceDemo
{
    public class LoginPage
    {
        IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement UserName => driver.FindElement(By.CssSelector("#user-name"));
        private IWebElement Password => driver.FindElement(By.CssSelector("#password"));
        private IWebElement LoginButton => driver.FindElement(By.CssSelector("#login-button"));

        public void Login()
        {
            UserName.SendKeys("standard_user");
            Password.SendKeys("secret_sauce");
            LoginButton.Click();
        }
    }
}
