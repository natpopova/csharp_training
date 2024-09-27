using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAaddressbookTests
{
    public class ContactData
    {
        //объявили переменные
        private string firstname = string.Empty;
        private string lastname = string.Empty;
        private string address = string.Empty;
        private string home = string.Empty;
        private string mobile = string.Empty;
        private string email = string.Empty;
        private string email2 = string.Empty;
        private string bday = string.Empty;
        private string bmonth = string.Empty;
        private string byear = string.Empty;

        //конструктор для отображаемых в таблице полей
        //public ContactData(string firstname, string lastname)
        //{
        //    this.firstname = firstname;
        //    this.lastname = lastname;
        //}

        //свойства
        public string Firstname { get { return firstname; } set { firstname = value; } }
        public string Lastname { get { return lastname; } set { lastname = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Home { get { return home; } set { home = value; } }
        public string Mobile { get { return mobile; } set { mobile = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Email2 { get { return email2; } set { email2 = value; } }
        public string Bday { get { return bday; } set { bday = value; } }
        public string Bmonth { get { return bmonth; } set { bmonth = value; } }
        public string Byear { get { return byear; } set { byear = value; } }

    }
}

