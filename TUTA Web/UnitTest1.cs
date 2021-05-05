using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TUTA_Web
{
    public class Tests
    {

        private IWebDriver driver;


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "http://automationpractice.com/index.php";



        }

        [Test]
        public void TestLogin()
        {
            string username = "petras.bibrinda@gmail.com";
            string password = "asdasd321";

            driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div.header_user_info > a")).Click();

            driver.FindElement(By.Id("email")).SendKeys(username);
            driver.FindElement(By.Id("passwd")).SendKeys(password);

            driver.FindElement(By.Id("SubmitLogin")).Click();

            IWebElement SignOut = driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div:nth-child(2) > a"));

            Assert.AreEqual("Sign out", SignOut.Text, "Login Successful");
        }

        [Test]
        public void TestItem()
        {

            string username = "petras.bibrinda@gmail.com";
            string password = "asdasd321";

            driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div.header_user_info > a")).Click();

            driver.FindElement(By.Id("email")).SendKeys(username);
            driver.FindElement(By.Id("passwd")).SendKeys(password);

            driver.FindElement(By.Id("SubmitLogin")).Click();

            IWebElement SignOut = driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div:nth-child(2) > a"));

            Assert.AreEqual("Sign out", SignOut.Text, "Login Successful");

            driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[6]/ul/li[3]/a")).Click();

            driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/ul/li/div/div[1]/div/a[1]/img")).Click();

            IWebElement WishList = driver.FindElement(By.CssSelector("#wishlist_button"));

            Assert.AreEqual("Add to wishlist", WishList.Text, "Item found successfully");
        }

        [Test]

        public void TestPurchase()
        {

            string username = "petras.bibrinda@gmail.com";
            string password = "asdasd321";

            driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div.header_user_info > a")).Click();

            driver.FindElement(By.Id("email")).SendKeys(username);
            driver.FindElement(By.Id("passwd")).SendKeys(password);

            driver.FindElement(By.Id("SubmitLogin")).Click();

            IWebElement SignOut = driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div:nth-child(2) > a"));

            Assert.AreEqual("Sign out", SignOut.Text, "Login Successful");

            driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[6]/ul/li[3]/a")).Click();

            driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/ul/li/div/div[1]/div/a[1]/img")).Click();

            driver.FindElement(By.Id("add_to_cart")).Click();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);



            driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/a")).Click();

            driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/p[2]/a[1]")).Click();

            driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/form/p/button")).Click();

            driver.FindElement(By.Id("cgv")).Click();

            driver.FindElement(By.CssSelector("#form > p > button")).Click();

            driver.FindElement(By.CssSelector("#HOOK_PAYMENT > div:nth-child(1) > div > p > a")).Click();

            driver.FindElement(By.CssSelector("#cart_navigation > button")).Click();

            IWebElement SuccessfulPurchase = driver.FindElement(By.CssSelector("#center_column > div > p > strong"));

            Assert.AreEqual("Your order on My Store is complete.", SuccessfulPurchase.Text, "Order Successful");
        }
        [TearDown]

        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}