using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace QA_Automation_SauceDemo
{
    public class CheckOutPage
    {
         IWebDriver driver;

         public CheckOutPage(IWebDriver driver)
         {
             this.driver = driver;
         }

         private IWebElement FirstName => driver.FindElement(By.CssSelector("#first-name"));
         private IWebElement LastName => driver.FindElement(By.CssSelector("#last-name"));
         private IWebElement ZipCode => driver.FindElement(By.CssSelector("#postal-code"));
         private IWebElement ContinueButton => driver.FindElement(By.CssSelector("#continue"));

         public void InPutData()
         {
            FirstName.SendKeys("Jonny");
            LastName.SendKeys("Jhon");
            ZipCode.SendKeys("8663");
            ContinueButton.Click();
         }
    }
}
