
namespace WEbAddressbookTests
{
    using NUnit.Framework;

    [NUnit.Framework.TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData ("admin", "secret")); 
            app.Navigator.GoToGroupPage();
            app.Groups.InitGroupCreation();
            GroupData group = new GroupData("aaa");
            group.Header = "ddd";
            group.Footer = "fff";
            app.Groups.FillGroupForm(group);
            app.Groups.SubmitCreation();
            app.Groups.ReturnToGroupsPage();
        }
        
    }
}
