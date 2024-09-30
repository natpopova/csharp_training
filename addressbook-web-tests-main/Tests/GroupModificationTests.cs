using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAaddressbookTests
{
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            //инициализировали тестовые данные
            GroupData newData = new GroupData("zzz");
            newData.Header = "qqq";
            newData.Footer = "rrr";

            app.GroupHelper.Modify(1, newData);
            //Logout();
        }

    }
}
