using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace QA_Automation_SauceDemo
{
    public class BaseTest
    {
       

        IWebDriver driver;
        LoginPage loginPage;
        HomePage homePage;
        CartPage cartPage;
        CheckOutPage checkOutPage;
        ProductInfoPage productInfoPage;
        ThankYouPage thankYouPage;

        [SetUp]
        public void Setup()
        {
            this.driver = new FirefoxDriver();
            this.loginPage =  new LoginPage(driver);
            this.homePage = new HomePage(driver);
            this.cartPage = new CartPage(driver);
            this.checkOutPage = new CheckOutPage(driver);
            this.productInfoPage = new ProductInfoPage(driver);
            this.thankYouPage = new ThankYouPage(driver);
        }

        [Test]
        public void EndToTest()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/inventory.html");
            loginPage.Login();
            homePage.AddBackPackToCart();
            homePage.AddTShirtToCart();
            homePage.ClickCartButton();
            cartPage.ClickCheckOut();
            checkOutPage.InPutData();
            productInfoPage.ClickFinish();

            string expectedMessage = "Thank you for your order!";

            string actualMessage = thankYouPage.GetThankYouMessage();

            Assert.AreEqual(expectedMessage, actualMessage);

        }
    }
}