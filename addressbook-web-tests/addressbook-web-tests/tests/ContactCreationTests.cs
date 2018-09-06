using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WEbAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {   
           
        [Test]
        public void ContactCreationTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Contacts.InitContactCreation();
            ContactData contact = new ContactData ("Sveta", "Storm");
            contact.Middlename = "Von";
            contact.Title = "PhD";
            contact.Mobile = "1234567";
            contact.Bday = "11";
            contact.Bmonth = "November";
            contact.Aday = "12";
            contact.Amonth = "November";
            app.Contacts.FillContactForm(contact);
            app.Contacts.SubmitCreation();
        }      
    }
}

