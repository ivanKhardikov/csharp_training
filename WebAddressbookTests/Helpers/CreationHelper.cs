using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class CreationHelper : BaseHelper
    {
        public CreationHelper(ApplicationManager manager) : base(manager)
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
        
        public void NoGroupCreation()
        {
            if (!IsElementPresent(By.XPath("//*[@class='group']")))
            {
                _manager.Create.CreatingNewGroup(new GroupData("a", "b", "c"));
                _manager.Navi.NavigateToGroupPage();
            }
        }
        
        public void NoContactCreation()
        {
            if (!IsElementPresent(By.XPath("//*[@name='entry']//input")))
            {
                _manager.Navi.NavigateToContactCreationPage();
                _manager.Create.CreatingNewContact(new ContactData("i", "kh"));
                _manager.Navi.NavigateToHomePage();
            }
        }
    }
}