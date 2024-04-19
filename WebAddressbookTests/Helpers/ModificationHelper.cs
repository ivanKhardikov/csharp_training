using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class ModificationHelper : BaseHelper
    {
        public ModificationHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void GroupModify(GroupData groupData, int index)
        {
            SelectGroup(index);
            InitGroupModification();
            FillGroupForm(groupData);
            SubmitGroupModification();
        }
        
        public void ContactModify(ContactData contactData)
        {
            EditContact();
            FillContactForm(contactData);
            SubmitContactModification();
        }

        public ModificationHelper InitGroupModification()
        {
            _driver.FindElement(By.Name("edit")).Click();
            return this;
        }
        
        public ModificationHelper SubmitGroupModification()
        {
            _driver.FindElement(By.Name("update")).Click();
            return this;
        }

        private void SelectGroup(int index)
        {
            _driver.FindElement(By.XPath($"//div[@id='content']/form/span[{index}]/input")).Click();
        }
        
        private void FillGroupForm(GroupData groupData)
        {
            Type(By.Name("group_name"), groupData.Groupname);
            Type(By.Name("group_header"), groupData.Header);
            Type(By.Name("group_footer"), groupData.Footer);
        }

        private void FillContactForm(ContactData contactData)
        {
            _driver.FindElement(By.Name("firstname")).Clear();
            _driver.FindElement(By.Name("firstname")).SendKeys(contactData.FirstName);
            _driver.FindElement(By.Name("lastname")).Clear();
            _driver.FindElement(By.Name("lastname")).SendKeys(contactData.FirstName);
        }
        
        private void EditContact()
        {
            _driver.FindElement(By.XPath($"//img[@title='Edit']")).Click();
        }

        public ModificationHelper SubmitContactModification()
        {
            _driver.FindElement(By.Name("update")).Click();
            return this;
        }
    }
}