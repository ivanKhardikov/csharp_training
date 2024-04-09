using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupDeletionTests : BaseTest
    {
        /// <summary>
        /// Проверка удаления группы
        /// </summary>
        [Test]
        public void GroupDeletionTest()
        {
            _manager.Auth.Login(new AccountData("admin", "secret"));
            _manager.Navi.NavigateToGroupPage();
            _manager.Delete.DeleteGroup();
            _manager.Quit.Logout();
        }
    }
}
