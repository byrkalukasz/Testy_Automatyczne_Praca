using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium;


namespace Eskok_autoTest
{
    class UserLogin
    {
        string LoginUser, ValidUserPassword = "11111111", InvalidUserPassword = "123456789";
        public UserLogin()
        {
        }

        [OneTimeSetUp]
        public void InitTest()
        {
        }

        [TestCase]
        public void ValidLoginAndPassword()
        {
            Driver.ChromeDriver = new ChromeDriver();
            Driver.ChromeDriver.Manage().Cookies.DeleteAllCookies();
            Config config = new Config();
            Header header = new Header();
            Autentyfication autentyfication = new Autentyfication();
            Homepage homepage = new Homepage();

            Driver.ChromeDriver.Manage().Window.Maximize();
            Driver.ChromeDriver.Navigate().GoToUrl(config.EskokAdress);
            LoginUser = autentyfication.ValidUserLoginSelect();
            homepage.LoginField.SendKeys(LoginUser);
            homepage.NextButton.Click();
            Thread.Sleep(1000);
            homepage.PasswordField.SendKeys(ValidUserPassword);
            homepage.LoginButton.Click();
            Thread.Sleep(1000);
            try
            {
                if (homepage.ErrorBox.Displayed)
                    Assert.Fail("Error błędny login lub konto zablokowane");
            }
            catch (NoSuchElementException)
            {}
            Driver.ChromeDriver.Quit();
        }
        [TestCase]
        public void ValidLoginInvalidPassword()
        {
            Driver.ChromeDriver = new ChromeDriver();
            Driver.ChromeDriver.Manage().Cookies.DeleteAllCookies();
            Config config = new Config();
            Header header = new Header();
            Autentyfication autentyfication = new Autentyfication();
            Homepage homepage = new Homepage();

            Driver.ChromeDriver.Manage().Window.Maximize();
            Driver.ChromeDriver.Navigate().GoToUrl(config.EskokAdress);
            LoginUser = autentyfication.ValidUserLoginSelect();
            homepage.LoginField.SendKeys(LoginUser);
            homepage.NextButton.Click();
            Thread.Sleep(1000);
            homepage.PasswordField.SendKeys(InvalidUserPassword);
            homepage.LoginButton.Click();
            try
            {
                if (homepage.ErrorBox.Displayed)
                    Thread.Sleep(1);
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("Error błędny login lub konto zablokowane");
            }
            Driver.ChromeDriver.Quit();
        }
        [TestCase]
        public void InvalidLoginValidPassword()
        {
            Driver.ChromeDriver = new ChromeDriver();
            Driver.ChromeDriver.Manage().Cookies.DeleteAllCookies();
            Config config = new Config();
            Header header = new Header();
            Autentyfication autentyfication = new Autentyfication();
            Homepage homepage = new Homepage();

            Driver.ChromeDriver.Manage().Window.Maximize();
            Driver.ChromeDriver.Navigate().GoToUrl(config.EskokAdress);
            LoginUser = autentyfication.InvalidUserLoginSelect();
            homepage.LoginField.SendKeys(LoginUser);
            homepage.NextButton.Click();
            Thread.Sleep(1000);
            homepage.PasswordField.SendKeys(ValidUserPassword);
            homepage.LoginButton.Click();
            Thread.Sleep(1000);
            try
            {
                if (homepage.ErrorBox.Displayed)
                    Thread.Sleep(1);
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("Error błędny login lub konto zablokowane");
            }
            Driver.ChromeDriver.Quit();
        }
        [TestCase]
        public void InvalidLoginInvalidPassword()
        {
            Driver.ChromeDriver = new ChromeDriver();
            Driver.ChromeDriver.Manage().Cookies.DeleteAllCookies();
            Config config = new Config();
            Header header = new Header();
            Autentyfication autentyfication = new Autentyfication();
            Homepage homepage = new Homepage();

            Driver.ChromeDriver.Manage().Window.Maximize();
            Driver.ChromeDriver.Navigate().GoToUrl(config.EskokAdress);
            LoginUser = autentyfication.InvalidUserLoginSelect();
            homepage.LoginField.SendKeys(LoginUser);
            homepage.NextButton.Click();
            Thread.Sleep(1000);
            homepage.PasswordField.SendKeys(InvalidUserPassword);
            homepage.LoginButton.Click();
            Thread.Sleep(1000);
            try
            {
                if (homepage.ErrorBox.Displayed)
                    Thread.Sleep(1);
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("Error błędny login lub konto zablokowane");
            }
            Driver.ChromeDriver.Quit();
        }
        [OneTimeTearDown]
        public void QuitTest()
        {
            Driver.ChromeDriver.Quit();
        }
    }
}
