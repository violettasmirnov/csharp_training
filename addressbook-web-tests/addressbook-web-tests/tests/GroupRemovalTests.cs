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
            app.Groups.CreateIfNeed();
            app.Groups.Remove(1);          
        }           
    }
}
