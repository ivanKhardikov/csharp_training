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
            _loginHelper.Login(new AccountData("admin", "secret"));
            
            _navigationHelper.NavigateToGroupPage();
            
            _deletionHelper.DeleteGroup();
            
            _logoutHelper.Logout();
        }
    }
}
