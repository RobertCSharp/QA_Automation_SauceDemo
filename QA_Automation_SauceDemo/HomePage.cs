using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace QA_Automation_SauceDemo
{
    public class HomePage
    {
        IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement BackPackToCartButton => driver.FindElement(By.CssSelector("#add-to-cart-sauce-labs-backpack"));
        private IWebElement TShirtToCartButton => driver.FindElement(By.CssSelector("#add-to-cart-sauce-labs-bolt-t-shirt"));
        private IWebElement CartButton => driver.FindElement(By.CssSelector(".shopping_cart_link"));

        public void AddBackPackToCart()
        {
            BackPackToCartButton.Click();
        }

        public void AddTShirtToCart()
        {
            TShirtToCartButton.Click();
        }

        public void ClickCartButton()
        {
            CartButton.Click();
        }
    }
}
