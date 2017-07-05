using NUnit.Framework;

namespace AddressBookWebTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            appManager.Navigator.GoToHomePage();
            appManager.Auth.Login(new AccountData("admin", "secret"));
            appManager.Contact.AddNewContactClick();
            ContactData contact = new ContactData("Vasya", "Pupkin");
            appManager.Contact.FillContactForm(contact);
            appManager.Contact.SubmitContactCreation();                       
        }                     
    }
}