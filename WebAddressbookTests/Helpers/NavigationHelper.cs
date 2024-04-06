using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class NavigationHelper : BaseHelper
    {
        protected string _baseUrl;

        public NavigationHelper(IWebDriver driver, string baseUrl) : base(driver)
        {
            _baseUrl = baseUrl;
        }

        public void NavigateToContactPage()
        {
            _driver.FindElement(By.LinkText("add new")).Click();
            _driver.Navigate().GoToUrl(_baseUrl + "/edit.php");
        }
        
        public void NavigateToGroupPage()
        {
            _driver.FindElement(By.LinkText("groups")).Click();
            _driver.Navigate().GoToUrl(_baseUrl + "/group.php");
        }
    }
}