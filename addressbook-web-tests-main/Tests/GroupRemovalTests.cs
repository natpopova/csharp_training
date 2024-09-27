using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAaddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            app.Navigate.GoToGroupsPage();
            app.GroupHelper
                .SelectGroup(1)
                .RemoveGroup()
                .ReturnToGroupsPage();
            //Logout();
        }
    }
}
