using NUnit.Framework;

namespace AddressBookWebTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            appManager.Groups.Remove(1);
            
        }                                    
    }
}