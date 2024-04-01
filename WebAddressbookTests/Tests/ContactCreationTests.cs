using System;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebAddressbookTests
{
    public class ContactCreationTests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        /// <summary>
        /// Проверка создания нового контакта
        /// </summary>
        [Test]
        public void ContractCreationTest()
        {
            Login(new AccountData("admin", "secret"));
            
            NavigateToContactPage();
            
            CreatingNewContact(new ContactData("Iv", "Kh"));
            
            Logout();
        }
        
        private void Login(AccountData accountData)
        {
            driver.Navigate().GoToUrl(baseURL);
            Thread.Sleep(2000);
            driver.FindElement(By.Name("user")).SendKeys(accountData.Username);
            driver.FindElement(By.Name("pass")).SendKeys(accountData.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }
        
        private void NavigateToContactPage()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            driver.Navigate().GoToUrl("http://localhost/addressbook/edit.php");
        }
        
        private void CreatingNewContact(ContactData contactData)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).SendKeys(contactData.FirstName);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).SendKeys(contactData.LastName);
            driver.FindElement(By.XPath("//div[@id='content']/form/input[20]")).Click();
        }
        
        private void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }
    }
}