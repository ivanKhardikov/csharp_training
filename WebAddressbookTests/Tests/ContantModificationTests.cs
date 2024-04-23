using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContantModificationTests : AuthTestBase
    {
        /// <summary>
        /// Проверка редактирования контакта
        /// </summary>
        [Test]
        public void ContactModificationTest()
        {
            ContactData contactData = new ContactData("Alex", "Ov");

            _manager.Navi.NavigateToHomePage();
            _manager.Create.NoContactCreation();
            _manager.Mode.ContactModify(contactData);
            _manager.Quit.Logout();
        }   
    }
}