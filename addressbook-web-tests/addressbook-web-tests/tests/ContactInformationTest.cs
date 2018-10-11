﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using NUnit.Framework;

namespace  WEbAddressbookTests

{
    [TestFixture]
    public class ContactInformationTest:AuthTestBase
    {
        [Test]
        public void TestContactInformation()
        {
           ContactData fromTable = app.Contacts.GetContactInformationFromTable(0);
           ContactData fromForm = app.Contacts.GetContactInformationFromEditForm(0);

            //verification
            Assert.AreEqual(fromTable, fromForm);
            Assert.AreEqual(fromTable.Address, fromForm.Address);
            Assert.AreEqual(fromTable.AllPhones, fromForm.AllPhones);
        }

    }
}
