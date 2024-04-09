using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class LogoutHelper : BaseHelper
    {
        public LogoutHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void Logout()
        {
            _driver.FindElement(By.LinkText("Logout")).Click();
        }
    }
}