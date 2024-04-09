using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContantModificationTests : BaseTest
    {
        /// <summary>
        /// Проверка редактирования контакта
        /// </summary>
        [Test]
        public void ContactModificationTest()
        {
            ContactData contactData = new ContactData("Alex", "Ov");

            _manager.Auth.Login(new AccountData("admin", "secret"));
            _manager.Mode.ContactModify(contactData);
            _manager.Quit.Logout();
        }   
    }
}