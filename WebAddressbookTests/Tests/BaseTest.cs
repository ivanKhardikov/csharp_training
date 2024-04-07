using NUnit.Framework;

namespace WebAddressbookTests
{
    public class BaseTest
    {
        protected ApplicationManager _manager;
        
        [SetUp]
        public void SetupTest()
        {
            _manager = new ApplicationManager();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            _manager.Stop();
        }
    }
}