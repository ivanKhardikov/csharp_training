using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : BaseTest
    {
        /// <summary>
        /// Проверка редактирования группы
        /// </summary>
        [Test]
        public void GroupModificationTest()
        {
            GroupData groupData = new GroupData("user", "head", "foot");

            _manager.Auth.Login(new AccountData("admin", "secret"));
            _manager.Mode.GroupModify(groupData, 1);
            _manager.Quit.Logout();
        }
    }
}