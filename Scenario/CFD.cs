using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium;


namespace Eskok_autoTest
{
    class CFD
    {
        Config config;
        Header header;
        Autentyfication autentyfication;
        Homepage homepage;
        OneTimeTransfer oneTimeTransfer;
        OneTimeTransferOverview OneTimeTransferOverview;
        OneTimeTransferAkcept OneTimeTransferAkcept;
        TransferLimit TransferLimit;
        ChangeDayLimit ChangeDayLimit;
        Action Action;

        string UserLogin = "0652566663", UserTransfer = "0652566663", ValidUserPassword = "11111111";
        string IBAN = "59809900042661806263260129";
        int status = 0; // Zero aby leciał kazdy test, pozostała liczba aby leciał jeden w koło 
                        //1 - powtarzanie logowania
                        //2 - powtarzanie przelewu
                        //3 - powtarzanie zmieny limitów

        public CFD()
        {
        }

        [SetUp]
        public void InitTest()
        {
        }

        [Test]
        public void RepearLoginAndLogOut_CFD()
        {
            SetDriver();
            do
            {
                Driver.ChromeDriver.Navigate().GoToUrl(config.EskokAdress);
                homepage.LoginField.SendKeys(UserLogin);
                homepage.NextButton.Click();
                Thread.Sleep(1000);
                homepage.PasswordField.SendKeys(ValidUserPassword);
                homepage.LoginButton.Click();
                Thread.Sleep(1000);
                header.LogoutButton.Click();
            } while (status == 1);
        }

        [Test]
        public void Transfer()
        {

            SetDriver();
            do
            {
                Driver.ChromeDriver.Navigate().GoToUrl(config.EskokAdress);
                homepage.LoginField.SendKeys(UserTransfer);
                homepage.NextButton.Click();
                Thread.Sleep(1000);
                homepage.PasswordField.SendKeys(ValidUserPassword);
                homepage.LoginButton.Click();
                Thread.Sleep(1000);
                header.OneTimeTransfer.Click();
                oneTimeTransfer.AmmountField.SendKeys("0.01");
                oneTimeTransfer.IBANField.SendKeys(IBAN);
                oneTimeTransfer.Odbioca.SendKeys("test");
                oneTimeTransfer.Szczegoly.SendKeys("Testowe szczegoly");
                oneTimeTransfer.NextButton.Click();
                OneTimeTransferOverview.NextButton.Click();
                string SMS = autentyfication.GetSmsPassword().ToString();
                OneTimeTransferAkcept.PasswordImput.SendKeys(SMS);
                OneTimeTransferAkcept.AkceptButton.Click();

            } while (status == 2);

        }

        [Test]
        public void ChangeLimits()
        {
            string DayLimit, MonthLimit, NewLimit;
            SetDriver();
            do
            {
                Driver.ChromeDriver.Navigate().GoToUrl(config.EskokAdress);
                homepage.LoginField.SendKeys(UserLogin);
                homepage.NextButton.Click();
                Thread.Sleep(1000);
                homepage.PasswordField.SendKeys(ValidUserPassword);
                homepage.LoginButton.Click();
                Thread.Sleep(1000);
                header.Settings.Click();
                TransferLimit.ChangeDayLimit.Click();
                DayLimit = ChangeDayLimit.DayLimit.Text;
                MonthLimit = ChangeDayLimit.MonthLimit.Text;
                NewLimit = Action.GetRandomFromRange(DayLimit, MonthLimit);
                ChangeDayLimit.NewLimitTextField.Clear();
                ChangeDayLimit.NewLimitTextField.SendKeys(NewLimit);

            } while (status == 3);
        }

        [TearDown]
        public void QuitTest()
        {
            Driver.ChromeDriver.Quit();
        }

        private void SetDriver()
        {
            Driver.ChromeDriver = new ChromeDriver();
            Driver.ChromeDriver.Manage().Cookies.DeleteAllCookies();
            Driver.ChromeDriver.Manage().Window.Maximize();

            config = new Config();
            header = new Header();
            autentyfication = new Autentyfication();
            homepage = new Homepage();
            oneTimeTransfer = new OneTimeTransfer();
            OneTimeTransferOverview = new OneTimeTransferOverview();
            OneTimeTransferAkcept = new OneTimeTransferAkcept();
            TransferLimit = new TransferLimit();
            ChangeDayLimit = new ChangeDayLimit();
            Action = new Action();
        }
    }
}