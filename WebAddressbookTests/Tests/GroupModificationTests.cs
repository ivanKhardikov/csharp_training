using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        /// <summary>
        /// Проверка редактирования группы
        /// </summary>
        [Test]
        public void GroupModificationTest()
        {
            GroupData groupData = new GroupData("user", "head", "foot");
            
            _manager.Navi.NavigateToGroupPage();
            _manager.Delete.NoGroupCreation();
            _manager.Mode.GroupModify(groupData, 1);
            _manager.Quit.Logout();
        }
    }
}