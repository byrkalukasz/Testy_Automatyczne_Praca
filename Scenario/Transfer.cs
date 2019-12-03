using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace Eskok_autoTest
{
    class Transfer
    {
        string LoginUser, ValidUserPassword = "11111111", InvalidUserPassword = "123456789", DayLimitTransfer, MonthLimitTransfer, AnavableMoney;
        public Transfer()
        { }
        [OneTimeSetUp]

        [TestCase]
        public void ValidTransfer()
        {
            Driver.ChromeDriver = new ChromeDriver();
            Driver.ChromeDriver.Manage().Cookies.DeleteAllCookies();
            Config config = new Config();
            Header header = new Header();
            Autentyfication autentyfication = new Autentyfication();
            Homepage homepage = new Homepage();
            MainPage mainpage = new MainPage();
            Action action = new Action();
            Actions actions = new Actions(Driver.ChromeDriver);
            TransferLimit transferLimit = new TransferLimit();
            Menu menu = new Menu();
            OneTimeTransfer oneTimeTransfer = new OneTimeTransfer();
            OneTimeTransferOverview oneTimeTransferOverview = new OneTimeTransferOverview();
            OneTimeTransferAkcept oneTimeTransferAkcept = new OneTimeTransferAkcept();
            string TransferMoney, IBAN, SMS;

            Driver.ChromeDriver.Manage().Window.Maximize();
            Driver.ChromeDriver.Navigate().GoToUrl(config.EskokAdress);
            LoginUser = autentyfication.ValidUserLoginSelect();
            homepage.LoginField.SendKeys(LoginUser);
            homepage.NextButton.Click();
            Thread.Sleep(1000);
            homepage.PasswordField.SendKeys(ValidUserPassword);
            homepage.LoginButton.Click();
            try
            {
                if (homepage.FirstAlertButton.Displayed)
                    homepage.FirstAlertButton.Click();
            }
            catch (NoSuchElementException)
            {
            }
            //header.Settings.Click();
            DayLimitTransfer = transferLimit.ChangeDayLimit.Text;
            MonthLimitTransfer = transferLimit.ChangeMonthLimit.Text;
            menu.Transfer.Click();
            AnavableMoney = oneTimeTransfer.AnavableMoney.Text;
            TransferMoney = action.GetValidTrasferAmmount(AnavableMoney,DayLimitTransfer,MonthLimitTransfer);
            oneTimeTransfer.AmmountField.SendKeys(TransferMoney);
            IBAN = action.GetValidIBANNumber();
            oneTimeTransfer.IBANField.SendKeys(IBAN);
            Thread.Sleep(1000);
            oneTimeTransfer.Odbioca.SendKeys("Test");
            oneTimeTransfer.Szczegoly.SendKeys("Test");
            actions.MoveToElement(oneTimeTransfer.NextButton);
            oneTimeTransfer.NextButton.Click();
            Thread.Sleep(2000);
            oneTimeTransferOverview.NextButton.Click();
            Thread.Sleep(5000);
            SMS = autentyfication.GetSmsPassword();
            oneTimeTransferAkcept.PasswordImput.SendKeys(SMS);
            Thread.Sleep(3000);
            oneTimeTransferAkcept.AkceptButton.Click();
            Thread.Sleep(3000);
            Driver.ChromeDriver.Quit();
        }
        [TestCase]
        public void InvalidAccountNumber()
        {
            Driver.ChromeDriver = new ChromeDriver();
            Driver.ChromeDriver.Manage().Cookies.DeleteAllCookies();
            Config config = new Config();
            Header header = new Header();
            Autentyfication autentyfication = new Autentyfication();
            Homepage homepage = new Homepage();
            MainPage mainpage = new MainPage();
            Actions actions = new Actions(Driver.ChromeDriver);

            Driver.ChromeDriver.Manage().Window.Maximize();
            Driver.ChromeDriver.Navigate().GoToUrl(config.EskokAdress);

            Driver.ChromeDriver.Quit();
        }
        [TestCase]
        public void InvalidMoneyTranfser()
        {
            Driver.ChromeDriver = new ChromeDriver();
            Driver.ChromeDriver.Manage().Cookies.DeleteAllCookies();
            Config config = new Config();
            Header header = new Header();
            Autentyfication autentyfication = new Autentyfication();
            Homepage homepage = new Homepage();
            MainPage mainpage = new MainPage();
            Actions actions = new Actions(Driver.ChromeDriver);

            Driver.ChromeDriver.Manage().Window.Maximize();
            Driver.ChromeDriver.Navigate().GoToUrl(config.EskokAdress);

            Driver.ChromeDriver.Quit();
        }
        [TestCase]
        public void TransferMoreThanDayLimit()
        {
            Driver.ChromeDriver = new ChromeDriver();
            Driver.ChromeDriver.Manage().Cookies.DeleteAllCookies();
            Config config = new Config();
            Header header = new Header();
            Autentyfication autentyfication = new Autentyfication();
            Homepage homepage = new Homepage();
            MainPage mainpage = new MainPage();
            Actions actions = new Actions(Driver.ChromeDriver);

            Driver.ChromeDriver.Manage().Window.Maximize();
            Driver.ChromeDriver.Navigate().GoToUrl(config.EskokAdress);

            Driver.ChromeDriver.Quit();
        }
        [TestCase]
        public void TransfetMoreThanMonthlyLimit()
        {
            Driver.ChromeDriver = new ChromeDriver();
            Driver.ChromeDriver.Manage().Cookies.DeleteAllCookies();
            Config config = new Config();
            Header header = new Header();
            Autentyfication autentyfication = new Autentyfication();
            Homepage homepage = new Homepage();
            MainPage mainpage = new MainPage();
            Actions actions = new Actions(Driver.ChromeDriver);

            Driver.ChromeDriver.Manage().Window.Maximize();
            Driver.ChromeDriver.Navigate().GoToUrl(config.EskokAdress);

            Driver.ChromeDriver.Quit();
        }
        [TestCase]
        public void BadSMSOrLHJPassword()
        {
            Driver.ChromeDriver = new ChromeDriver();
            Driver.ChromeDriver.Manage().Cookies.DeleteAllCookies();
            Config config = new Config();
            Header header = new Header();
            Autentyfication autentyfication = new Autentyfication();
            Homepage homepage = new Homepage();
            MainPage mainpage = new MainPage();
            Actions actions = new Actions(Driver.ChromeDriver);

            Driver.ChromeDriver.Manage().Window.Maximize();
            Driver.ChromeDriver.Navigate().GoToUrl(config.EskokAdress);

            Driver.ChromeDriver.Quit();
        }
        [OneTimeTearDown]
        public void QuitTest()
        {
        }
    }
}
