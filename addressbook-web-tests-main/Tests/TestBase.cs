using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAaddressbookTests;


namespace WebAaddressbookTests
{
     public class TestBase
    {
        protected ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {
            app = ApplicationManager.GetInstance(); ;

        }

        //protected void Logout()
        //{
        //    driver.FindElement(By.LinkText("Logout")).Click();
        //}
    }
}
