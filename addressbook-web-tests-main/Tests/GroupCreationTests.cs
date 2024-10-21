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
    public class GroupCreationTests : AuthTestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            //инициализировали тестовые данные
            GroupData group = new GroupData("q");
            group.Header = "q";
            group.Footer = "qw";

            app.GroupHelper.Сreate(group);
            //Logout();
        }
        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            app.GroupHelper.Сreate(group);
            //Logout();
        }
    }
}
