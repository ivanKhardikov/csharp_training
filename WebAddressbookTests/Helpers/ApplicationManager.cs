using System;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebAddressbookTests
{
    public class ApplicationManager
    {
        protected IWebDriver _driver;
        private StringBuilder _verificationErrors;
        protected string _baseURL;
        
        protected LoginHelper _loginHelper;
        protected NavigationHelper _navigationHelper;
        protected CreationHelper _creationHelper;
        protected DeletionHelper _deletionHelper;
        protected LogoutHelper _logoutHelper;
        
        public ApplicationManager()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _baseURL = "http://localhost/addressbook";
            _verificationErrors = new StringBuilder();
            
            _loginHelper = new LoginHelper(_driver, _baseURL);
            _navigationHelper = new NavigationHelper(_driver, _baseURL);
            _creationHelper = new CreationHelper(_driver);
            _deletionHelper = new DeletionHelper(_driver);
            _logoutHelper = new LogoutHelper(_driver);
        }

        public void Stop()
        {
            try
            {
                _driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public LoginHelper Auth
        {
            get
            {
                return _loginHelper;
            }
        }

        public CreationHelper Create
        {
            get
            {
                return _creationHelper;
            }

        }

        public DeletionHelper Delete
        {
            get
            {
                return _deletionHelper;
            }
        }

        public NavigationHelper Navi
        {
            get
            {
                return _navigationHelper;
            }
        }

        public LogoutHelper Quit
        {
            get
            {
                return _logoutHelper;
            }
        }
    }
}