using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAaddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            app.Navigate.GoToAddNewContactPage();
            // создаёт объект group класса ContactData
            ContactData group = new ContactData();
            group.Firstname = "admin2";
            group.Lastname = "admin2";
            group.Address = "Black str";
            //group.Home = 123456789;
            group.Mobile = "12345";
            group.Email = "email1";
            group.Bday = "1";
            group.Bmonth = "May";
            group.Byear = "2000";
            app.ContactHelper.FillContactForm(group);
            app.ContactHelper.SubmitContactCreation();
            app.ContactHelper.ReturnToHomePage();
            //Logout();
        }
    }
}
