using NUnit.Framework;

namespace WebAddressbookTests
{
    public class AuthTestBase : BaseTest
    {
        [SetUp]
        public void SetupLogin()
        {
            _manager.Auth.Login(new AccountData("admin", "secret"));
        }
    }
}