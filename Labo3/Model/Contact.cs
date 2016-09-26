using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Contact
    {
        /*
        private String firstName;
        private String lastName;
        private String mail;
        */

        public String FirstName
        {
            get;
            set;
        }

        public String LastName
        {
            get;
            set;
        }

        public String Mail
        {
            get;
            set;
        }

        public Contact(String firstName, String lastName, String mail)
        {
            FirstName = firstName;
            LastName = LastName;
            Mail = mail;
        }
    }
}
