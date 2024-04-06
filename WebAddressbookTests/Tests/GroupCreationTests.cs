using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : BaseTest
    {
        /// <summary>
        /// Проверка создания группы
        /// </summary>
        [Test]
        public void GroupCreationTest()
        {
            _manager.Auth.Login(new AccountData("admin", "secret"));
            
            _manager.Navi.NavigateToGroupPage();
            
            _manager.Create.CreatingNewGroup(new GroupData("test", "admin", "test"));
            
            _manager.Quit.Logout();
        }
    }
}
