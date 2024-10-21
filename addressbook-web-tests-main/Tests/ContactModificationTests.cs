using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAaddressbookTests
{
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            // создаёт объект newData класса ContactData
            ContactData newData = new ContactData();
            newData.Firstname = "admin50";
            newData.Lastname = "admin50";
            newData.Address = "Red str";
            //newData.Home = 123456789;
            newData.Mobile = "123450";
            newData.Email = "email50";
            newData.Bday = "1";
            newData.Bmonth = "June";
            newData.Byear = "2005";

            app.ContactHelper.Modify(1, newData);
            //Logout();
        }

    }
}
