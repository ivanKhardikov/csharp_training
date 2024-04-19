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

        public void NoGroupCreation()
        {
            if (!IsElementPresent(By.XPath("//*[@class='group']")))
            {
                _manager.Create.CreatingNewGroup(new GroupData("a", "b", "c"));
                _manager.Navi.NavigateToGroupPage();
            }
        }
        
        public void DeleteContact()
        {
            _driver.FindElement(By.Name("selected[]")).Click();
            _driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
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