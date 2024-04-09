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
            _manager.Auth.Login(new AccountData("admin", "secret"));
            _manager.Navi.NavigateToContactCreationPage();
            _manager.Create.CreatingNewContact(new ContactData("Iv", "Kh"));
            _manager.Quit.Logout();
        }
    }
}