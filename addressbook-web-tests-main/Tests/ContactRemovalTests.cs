using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace WebAaddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {
        [Test]

        public void ContactRemovalTest()
        {
            app.ContactHelper.Remove(2);
        }
    }
}
