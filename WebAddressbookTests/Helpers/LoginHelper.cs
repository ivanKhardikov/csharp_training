using System.Threading;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class LoginHelper : BaseHelper
    {
        protected string _baseUrl;

        public LoginHelper(ApplicationManager manager, string baseUrl) : base(manager)
        {
            _baseUrl = baseUrl;
        }
        
        public void Login(AccountData accountData)
        {
            _driver.Navigate().GoToUrl(_baseUrl);
            Thread.Sleep(2000);
            Type(By.Name("user"), accountData.Username);
            Type(By.Name("pass"), accountData.Password);
            _driver.FindElement(By.XPath("//input[@value='Login']")).Click();
            
            
        }
    }
}