using NUnit.Framework;

namespace WebAddressbookTests
{
    public class BaseTest
    {
        protected ApplicationManager _manager;
        
        [SetUp]
        public void SetupTest()
        {
            _manager = ApplicationManager.GetInstance();
        }
    }
}