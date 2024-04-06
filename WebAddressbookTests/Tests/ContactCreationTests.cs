using NUnit.Framework;

namespace WebAddressbookTests
{
    public class ContactCreationTests : BaseTest
    {
        /// <summary>
        /// Проверка создания нового контакта
        /// </summary>
        [Test]
        public void ContractCreationTest() 
        {
            _loginHelper.Login(new AccountData("admin", "secret"));
            
            _navigationHelper.NavigateToContactPage();
            
            _creationHelper.CreatingNewContact(new ContactData("Iv", "Kh"));
            
            _logoutHelper.Logout();
        }
    }
}