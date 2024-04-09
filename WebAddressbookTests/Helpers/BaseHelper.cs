using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class BaseHelper
    {
        public IWebDriver _driver;
        public ApplicationManager _manager;

        public BaseHelper(ApplicationManager manager)
        {
            _manager = manager;
            _driver = manager.Driver;
        }
    }
}