using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WEbAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {   
           
        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData ("Sveta", "Storm");
            contact.Middlename = "Von";
            contact.Title = "PhD";
            contact.Mobile = "1234567";
            contact.Bday = "11";
            contact.Bmonth = "November";
            contact.Aday = "12";
            contact.Amonth = "November";

            app.Contacts.Create(contact);
        }

        [Test]
        public void EmptyContactCreationTest()
        {
            ContactData contact = new ContactData("", "");
            contact.Middlename = "";
            contact.Title = "";
            contact.Mobile = "";
            contact.Bday = "11";
            contact.Bmonth = "November";
            contact.Aday = "12";
            contact.Amonth = "November";

            app.Contacts.Create(contact);
        }
    }
}

