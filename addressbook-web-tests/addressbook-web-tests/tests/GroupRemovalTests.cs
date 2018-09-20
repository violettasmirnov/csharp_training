using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WEbAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {        
        [Test]
        
        public void GroupRemovalTest()
        {
           app.Groups.CreateIfNeed(1);
           app.Groups.Remove(1);          
        }           
    }
}
