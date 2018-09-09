
namespace WEbAddressbookTests
{
    using NUnit.Framework;

    [NUnit.Framework.TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            app.Navigator.GoToGroupPage();
            
            GroupData group = new GroupData("aaa");
            group.Header = "ddd";
            group.Footer = "fff";
            app.Groups
                .InitGroupCreation()
                .FillGroupForm(group)
                .SubmitCreation()
                .ReturnToGroupsPage();
        }
        
    }
}
