using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class DeletionHelper : BaseHelper
    {
        public DeletionHelper(IWebDriver driver) : base(driver)
        {
        }

        public void DeleteGroup()
        {
            _driver.FindElement(By.Name("selected[]")).Click();
            _driver.FindElement(By.Name("delete")).Click();
        }
    }
}