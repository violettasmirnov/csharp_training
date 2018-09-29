using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using NUnit.Framework;

namespace WEbAddressbookTests.tests

{
    [TestFixture]
    public class ContactModificationTests :AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("Sidorov","Sam");
            newData.Bday = "10";
            newData.Bmonth = "October";
            newData.Aday = "10";
            newData.Amonth = "December";

            app.Contacts.CreateIfNeed(0);

            List<ContactData> oldcontacts = app.Contacts.GetContactList();
                        
            app.Contacts.Modify(0, newData);

            List<ContactData> newcontacts = app.Contacts.GetContactList();

            oldcontacts[0].Lastname = newData.Lastname;
            oldcontacts[0].Firstname = newData.Firstname;
            oldcontacts.Sort();
            newcontacts.Sort();
            Assert.AreEqual(oldcontacts, newcontacts);

        }
    }
}
