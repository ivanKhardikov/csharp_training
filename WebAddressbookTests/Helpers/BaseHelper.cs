using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class BaseHelper
    {
        public IWebDriver _driver;

        public BaseHelper(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}