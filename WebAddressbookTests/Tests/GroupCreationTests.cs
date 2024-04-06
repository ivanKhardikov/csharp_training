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
            _loginHelper.Login(new AccountData("admin", "secret"));
            
            _navigationHelper.NavigateToGroupPage();
            
            _creationHelper.CreatingNewGroup(new GroupData("test", "admin", "test"));
            
            _logoutHelper.Logout();
        }
    }
}
