using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class NavigationHelper : BaseHelper
    {
        protected string _baseUrl;

        public NavigationHelper(ApplicationManager manager, string baseUrl) : base(manager)
        {
            _baseUrl = baseUrl;
        }

        public void NavigateToContactCreationPage()
        {
            _driver.FindElement(By.LinkText("add new")).Click();
            _driver.Navigate().GoToUrl(_baseUrl + "/edit.php");
        }
        
        public void NavigateToHomePage()
        {
            _driver.Navigate().GoToUrl(_baseUrl + "/index.php");
        }
        
        public void NavigateToGroupPage()
        {
            _driver.FindElement(By.LinkText("groups")).Click();
            _driver.Navigate().GoToUrl(_baseUrl + "/group.php");
        }
    }
}