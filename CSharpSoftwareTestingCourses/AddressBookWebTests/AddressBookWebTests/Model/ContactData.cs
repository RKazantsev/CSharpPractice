namespace AddressBookWebTests
{
    public class ContactData
    {
        private string name;
        private string lastName;

        public ContactData(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
    }
}