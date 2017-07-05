using NUnit.Framework;

namespace AddressBookWebTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {         
            ContactData contact = new ContactData("Vasya", "Pupkin");
            appManager.Contact.Create(contact);                                      
        }                     
    }
}