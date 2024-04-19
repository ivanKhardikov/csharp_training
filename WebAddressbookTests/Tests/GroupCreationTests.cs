using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
        /// <summary>
        /// Проверка создания группы
        /// </summary>
        [Test]
        public void GroupCreationTest()
        {
            _manager.Navi.NavigateToGroupPage();
            _manager.Create.CreatingNewGroup(new GroupData("test", "admin", "test"));
            _manager.Quit.Logout();
        }
    }
}
