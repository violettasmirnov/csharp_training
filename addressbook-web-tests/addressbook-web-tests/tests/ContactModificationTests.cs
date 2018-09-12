using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WEbAddressbookTests.tests

{
    [TestFixture]
    public class ContactModificationTests :TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("Ivan", "Ivanov");
            newData.Middlename = "Ivanych";
            newData.Title = "";
            newData.Mobile = "7654321";
            newData.Bday = "10";
            newData.Bmonth = "October";
            newData.Aday = "10";
            newData.Amonth = "December";
            app.Contacts.Modify(1, newData);
        }
    }
}
