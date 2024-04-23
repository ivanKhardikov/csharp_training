using NUnit.Framework;

namespace WebAddressbookTests
{
    public class ContantDeletionTests : AuthTestBase
    {
        /// <summary>
        /// Проверка удаления контактов
        /// </summary>
        [Test]
        public void ContactDeletionTest()
        {
            _manager.Navi.NavigateToHomePage();
            _manager.Create.NoContactCreation();
            _manager.Delete.DeleteContact();
            _manager.Quit.Logout();
        }
    }
}