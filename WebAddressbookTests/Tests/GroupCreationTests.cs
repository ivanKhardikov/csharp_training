using System;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests
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
        /// Проверка создания группы
        /// </summary>
        [Test]
        public void GroupCreationTest()
        {
            Login(new AccountData("admin", "secret"));
            
            NavigateToGroupPage();
            
            CreatingNewGroup(new GroupData("test", "admin", "test"));
            
            driver.FindElement(By.LinkText("group page")).Click();
            
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

        private void NavigateToGroupPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
            driver.Navigate().GoToUrl("http://localhost/addressbook/group.php");
        }
        
        private void CreatingNewGroup(GroupData groupData)
        {
            driver.FindElement(By.Name("new")).Click();
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).SendKeys(groupData.Groupname);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).SendKeys(groupData.Header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).SendKeys(groupData.Footer);
            driver.FindElement(By.Name("submit")).Click();
        }

        private void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }
    }
}
