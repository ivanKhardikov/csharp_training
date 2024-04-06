using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebAddressbookTests
{
    public class BaseTest
    {
        protected IWebDriver _driver;
        private StringBuilder _verificationErrors;
        protected string _baseURL;
        protected LoginHelper _loginHelper;
        protected NavigationHelper _navigationHelper;
        protected CreationHelper _creationHelper;
        protected DeletionHelper _deletionHelper;
        protected LogoutHelper _logoutHelper;
        
        [SetUp]
        public void SetupTest()
        {
            _driver = new ChromeDriver();
            _baseURL = "http://localhost/addressbook";
            _verificationErrors = new StringBuilder();
            _loginHelper = new LoginHelper(_driver, _baseURL);
            _navigationHelper = new NavigationHelper(_driver, _baseURL);
            _creationHelper = new CreationHelper(_driver);
            _deletionHelper = new DeletionHelper(_driver);
            _logoutHelper = new LogoutHelper(_driver);
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                _driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", _verificationErrors.ToString());
        }
    }
}