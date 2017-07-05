using NUnit.Framework;

namespace AddressBookWebTests
{
    [TestFixture]
    public class TestBase
    {              
        protected AppManager appManager;

        [SetUp]
        public void SetupTest()
        {            
            appManager = new AppManager();
            appManager.Navigator.GoToHomePage();
            appManager.Auth.Login(new AccountData("admin", "secret"));
        }

        [TearDown]
        public void TeardownTest()
        {
            appManager.Stop();  
        }                        
    }
}