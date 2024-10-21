using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAaddressbookTests

{
    [TestFixture]

    public class LoginTests : TestBase
    {

        [Test]

        public void LoginWithValidCredentials()
        {
            //preparation
            app.Auth.LogOut();

            //action
            AccountData account = new AccountData("admin", "secret");
            app.Auth.Login(account);

            //verification
            Assert.IsTrue(app.Auth.IsLoggedIn(account));
        }

        [Test]

        public void LoginWithInvalidCredentials()
        {
            //preparation
            app.Auth.LogOut();

            //action
            AccountData account = new AccountData("admin", "123");
            app.Auth.Login(account);

            //verification
            Assert.IsFalse(app.Auth.IsLoggedIn(account));
        }
    }
}