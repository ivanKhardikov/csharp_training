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
        
        public void Type(By locator, string text)
        {
            if (text != null)
            {
                _driver.FindElement(locator).Clear();
                _driver.FindElement(locator).SendKeys(text);
            }
        }
    }
}