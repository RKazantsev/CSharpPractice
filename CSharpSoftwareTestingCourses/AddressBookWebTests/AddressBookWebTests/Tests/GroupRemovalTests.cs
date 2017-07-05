using NUnit.Framework;

namespace AddressBookWebTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            appManager.Navigator.GoToHomePage();
            appManager.Auth.Login(new AccountData("admin", "secret"));
            appManager.Navigator.GoToGroupsPage();
            appManager.Groups.SelectGroup(1);
            appManager.Groups.RemoveGroup(1);
            appManager.Groups.ReturnToGroupsPage();
        }                                    
    }
}