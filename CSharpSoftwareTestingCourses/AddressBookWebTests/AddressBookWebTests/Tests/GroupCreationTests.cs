using NUnit.Framework;

namespace AddressBookWebTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            appManager.Navigator.GoToHomePage();
            appManager.Auth.Login(new AccountData("admin", "secret"));
            appManager.Navigator.GoToGroupsPage();
            appManager.Groups.InitGroupCreation();
            GroupData group = new GroupData("aaa");
            group.Header = "bbb";
            group.Footer = "ccc";
            appManager.Groups.FillGroupForm(group);
            appManager.Groups.SubmitGroupCreation();
            appManager.Groups.ReturnToGroupsPage();
        }                               
    }
}