using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WEbAddressbookTests.tests

{
    [TestFixture]
    public class ContactModificationTests :AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("Ivan", "Sidorov");
            newData.Bday = "10";
            newData.Bmonth = "October";
            newData.Aday = "10";
            newData.Amonth = "December";

            app.Contacts.CreateIfNeed();
            app.Contacts.Modify(1, newData);
        }
    }
}
