using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace WebAaddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {

        [Test]
        public void GroupCreationTest()
        {
            app.Navigate.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigate.GoToGroupsPage();
            GroupData group = new GroupData("q");
            group.Header = "q";
            group.Footer = "qw";
            app.GroupHelper
                .InitGroupCreation()
                .FillGroupForm(group)
                .SubmitGroupCreation()
                .ReturnToGroupsPage();
            //Logout();
        }
    }
}
