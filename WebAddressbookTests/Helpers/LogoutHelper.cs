using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class LogoutHelper : BaseHelper
    {
        public LogoutHelper(IWebDriver driver) : base(driver)
        {
        }

        public void Logout()
        {
            _driver.FindElement(By.LinkText("Logout")).Click();
        }
    }
}