using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class CreationHelper : BaseHelper
    {
        public CreationHelper(IWebDriver driver) : base(driver)
        {
        }

        public void CreatingNewContact(ContactData contactData)
        {
            _driver.FindElement(By.Name("firstname")).Click();
            _driver.FindElement(By.Name("firstname")).SendKeys(contactData.FirstName);
            _driver.FindElement(By.Name("lastname")).Click();
            _driver.FindElement(By.Name("lastname")).SendKeys(contactData.LastName);
            _driver.FindElement(By.XPath("//div[@id='content']/form/input[20]")).Click();
        }
        
        public void CreatingNewGroup(GroupData groupData)
        {
            _driver.FindElement(By.Name("new")).Click();
            _driver.FindElement(By.Name("group_name")).Click();
            _driver.FindElement(By.Name("group_name")).SendKeys(groupData.Groupname);
            _driver.FindElement(By.Name("group_header")).Click();
            _driver.FindElement(By.Name("group_header")).SendKeys(groupData.Header);
            _driver.FindElement(By.Name("group_footer")).Click();
            _driver.FindElement(By.Name("group_footer")).SendKeys(groupData.Footer);
            _driver.FindElement(By.Name("submit")).Click();
        }
    }
}