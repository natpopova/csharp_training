﻿using System;
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
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            InitGroupCreation();
            GroupData group = new GroupData("q");
            group.Header = "q";
            group.Footer = "qw";
            SubmitGroupCreation();
            ReturnToGroupsPage();
            Logout();
        }
    }
}
