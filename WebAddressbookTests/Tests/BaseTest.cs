using NUnit.Framework;

namespace WebAddressbookTests
{
    public class BaseTest
    {
        protected ApplicationManager _manager;
        
        [SetUp]
        public void SetupApplicationManager()
        {
            _manager = ApplicationManager.GetInstance();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            _manager.Stop();
        }
    }
}