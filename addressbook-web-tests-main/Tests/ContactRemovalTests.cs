using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace WebAaddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : TestBase
    {
        [Test]

        public void ContactRemovalTest()
        {
            app.ContactHelper.Remove(2);
        }
    }
}
