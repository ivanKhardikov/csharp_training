using System;
using System.Text;
using System.Threading;
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
        protected ModificationHelper _modificationHelper;
        protected CreationHelper _creationHelper;
        protected DeletionHelper _deletionHelper;
        protected LogoutHelper _logoutHelper;
        
        private static ThreadLocal<ApplicationManager> instance = new ThreadLocal<ApplicationManager>();

        private ApplicationManager()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _baseURL = "http://localhost/addressbook";
            _verificationErrors = new StringBuilder();
            
            _loginHelper = new LoginHelper(this, _baseURL);
            _navigationHelper = new NavigationHelper(this, _baseURL);
            _creationHelper = new CreationHelper(this);
            _deletionHelper = new DeletionHelper(this);
            _logoutHelper = new LogoutHelper(this);
            _modificationHelper = new ModificationHelper(this);
        }

        ~ApplicationManager()
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

        public static ApplicationManager GetInstance()
        {
            if (!instance.IsValueCreated)
            {
                instance.Value = new ApplicationManager();
            }
            return instance.Value;
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
        
        public ModificationHelper Mode
        {
            get
            {
                return _modificationHelper;
            }
        }

        public LogoutHelper Quit
        {
            get
            {
                return _logoutHelper;
            }
        }
        
        public IWebDriver Driver
        {
            get
            {
                return _driver;
            }
        }
    }
}