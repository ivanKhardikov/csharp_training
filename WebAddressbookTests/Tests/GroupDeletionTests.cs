using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupDeletionTests : AuthTestBase
    {
        /// <summary>
        /// Проверка удаления группы
        /// </summary>
        [Test]
        public void GroupDeletionTest()
        {
            _manager.Navi.NavigateToGroupPage();
            _manager.Create.NoGroupCreation();
            _manager.Delete.DeleteGroup();
            _manager.Quit.Logout();
        }
    }
}
