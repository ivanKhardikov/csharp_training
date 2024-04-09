using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class DeletionHelper : BaseHelper
    {
        public DeletionHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void DeleteGroup()
        {
            _driver.FindElement(By.Name("selected[]")).Click();
            _driver.FindElement(By.Name("delete")).Click();
        }
        
        public void DeleteContact()
        {
            _driver.FindElement(By.Name("selected[]")).Click();
            _driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
        }
    }
}