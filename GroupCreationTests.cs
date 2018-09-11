﻿
namespace WEbAddressbookTests
{
    using NUnit.Framework;

    [NUnit.Framework.TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {         
            GroupData group = new GroupData("aaa");
            group.Header = "ddd";
            group.Footer = "fff";

            app.Groups.Create(group);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
            
            app.Groups.Create(group);
        }
    }
}
