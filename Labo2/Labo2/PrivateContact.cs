using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class PrivateContact : Person
    {
        private String phoneNumber;
        private String mail;
        private DateTime birthday;

        public String PhoneNumber
        {
            get;
            set;
        }

        public String Mail
        {
            get;
            set;
        }

        public DateTime BirthDay
        {
            get;
            set;
        }

        public PrivateContact(String name, String lastName, String phoneNumber, String mail, DateTime birthday) : base(name, lastName)
        {
            PhoneNumber = phoneNumber;
            Mail = mail;
            BirthDay = birthday;
        }

        public PrivateContact(String name, String lastName, String phoneNumber, String mail) : base(name, lastName)
        {
            PhoneNumber = phoneNumber;
            Mail = mail;
        }

        public override bool HasBirthday()
        {
            return (DateTime.Today.Month == BirthDay.Month && DateTime.Today.Day == BirthDay.Day) ;
        }

        public override String ToString()
        {
            return base.ToString() + " N° téléphone : " + PhoneNumber + "\nMail : " + Mail +"\n";
        }

        public String Print()
        {
            return Name+" "+LastName+" est un contact privé";
        }
    }
}
