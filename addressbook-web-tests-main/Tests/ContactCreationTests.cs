using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAaddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            // создаёт объект group класса ContactData
            ContactData group = new ContactData();
            group.Firstname = "admin new";
            group.Lastname = "admin new";
            group.Address = "Yello str";
            //group.Home = 123456789;
            group.Mobile = "12345";
            group.Email = "email new";
            group.Bday = "22";
            group.Bmonth = "May";
            group.Byear = "2000";

            app.ContactHelper.Create(group);
            //Logout();
        }
    }
}
