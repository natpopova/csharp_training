using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace WebAaddressbookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager)
            : base(manager)
        {
        }

        public ContactHelper Create(ContactData group)
        {
            manager.Navigate.OpenHomePage();
            manager.Navigate.GoToAddNewContactPage();
            FillContactForm(group);
            SubmitContactCreation();
            ReturnToHomePage();
            return this;
        }

        public ContactHelper FillContactForm(ContactData group)
        {
            Type(By.Name("firstname"), group.Firstname);
            Type(By.Name("lastname"), group.Lastname);
            Type(By.Name("address"), group.Address);
            Type(By.Name("home"), group.Home);

            Type(By.Name("mobile"), group.Mobile);
            Type(By.Name("email"), group.Email);
            Type(By.Name("email2"), group.Email2);

            driver.FindElement(By.Name("bday")).Click();
            new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText(group.Bday);
            driver.FindElement(By.Name("bmonth")).Click();
            new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText(group.Bmonth);

            Type(By.Name("byear"), group.Byear);
            return this;
        }

        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.XPath("//input[20]")).Click();
            return this;
        }

        public ContactHelper Modify(int v, ContactData newData)
        {
            manager.Navigate.OpenHomePage();
            driver.FindElement(By.XPath("//tr[3]/td[8]/a/img")).Click();
            FillContactForm(newData);
            driver.FindElement(By.Name("update")).Click();
            ReturnToHomePage();
            return this;
        }

        public ContactHelper ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
            return this;
        }

        public ContactHelper Remove(int p)
        {
            manager.Navigate.OpenHomePage();
            SelectContact(p);
            RemoveContact();
            return this;
        }


        public ContactHelper SelectContact(int index)
        {
            driver.FindElement(By.XPath($"(//input[@type='checkbox'])[{index}]")).Click();

            return this;
        }

        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }
    }
}
