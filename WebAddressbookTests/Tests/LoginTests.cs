using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class LoginTests : BaseTest
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            _manager.Auth.Logout();

            AccountData account = new AccountData("admin", "secret");
            _manager.Auth.Login(account);
            
            Assert.IsTrue(_manager.Auth.IsLoggedIn(account));
        }
        
        [Test]
        public void LoginWithInvalidCredentials()
        {
            _manager.Auth.Logout();

            AccountData account = new AccountData("admin", "123123");
            _manager.Auth.Login(account);
            
            Assert.IsFalse(_manager.Auth.IsLoggedIn(account));
        }
    }
}