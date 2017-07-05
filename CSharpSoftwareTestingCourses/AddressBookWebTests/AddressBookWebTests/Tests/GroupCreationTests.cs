using NUnit.Framework;

namespace AddressBookWebTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {              
            GroupData group = new GroupData("aaa");
            group.Header = "bbb";
            group.Footer = "ccc";            
            appManager.Groups.Create(group);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";            
            appManager.Groups.Create(group);
        }
    }
}