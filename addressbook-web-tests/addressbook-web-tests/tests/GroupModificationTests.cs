using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WEbAddressbookTests.tests
{
    [TestFixture]
    public class GroupModificationTests: AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {            
            GroupData newData = new GroupData("zzz");
            newData.Header = null;
            newData.Footer = "ttt";

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            //app.Groups.CreateIfNeed(0);
            app.Groups.Modify(0, newData);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups[0].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
