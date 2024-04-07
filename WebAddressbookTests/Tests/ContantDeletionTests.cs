using NUnit.Framework;

namespace WebAddressbookTests
{
    public class ContantDeletionTests : BaseTest
    {
        /// <summary>
        /// Проверка удаления контактов
        /// </summary>
        [Test]
        public void ContactDeletionTest()
        {
            _manager.Auth.Login(new AccountData("admin", "secret"));
            
            _manager.Navi.NavigateToContactDeletionPage();
            
            _manager.Delete.DeleteContact();
            
            _manager.Quit.Logout();
        }
    }
}