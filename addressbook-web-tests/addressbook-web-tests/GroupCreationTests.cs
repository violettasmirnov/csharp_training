
namespace WEbAddressbookTests
{
    using NUnit.Framework;

    [NUnit.Framework.TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GoToHomePage();
            Login(new AccountData ("admin", "secret")); 
            GoToGroupPage();
            InitGroupCreation();
           // Login(new AccountData("admin", "secret"));
            //InitGroupCreation();
            GroupData group = new GroupData("aaa");
            group.Header = "ddd";
            group.Footer = "fff";
            FillGroupForm(group);
            SubmitCreation();
            ReturnToGroupsPage();

        }
        
    }
}
