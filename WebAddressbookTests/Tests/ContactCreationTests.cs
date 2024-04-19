using NUnit.Framework;

namespace WebAddressbookTests
{
    public class ContactCreationTests : AuthTestBase
    {
        /// <summary>
        /// Проверка создания нового контакта
        /// </summary>
        [Test]
        public void ContractCreationTest() 
        {
            _manager.Navi.NavigateToContactCreationPage();
            _manager.Create.CreatingNewContact(new ContactData("Iv", "Kh"));
            _manager.Quit.Logout();
        }
    }
}