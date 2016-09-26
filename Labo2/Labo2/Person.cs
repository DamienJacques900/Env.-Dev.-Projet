using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    public abstract class Person
    {
        private String name;
        private String lastName;

        public String Name
        {
            get;
            set;
        }

        public String LastName
        {
            get;
            set;
        }

        public Person(String name, String lastName)
        {
            Name = name;
            LastName = lastName;
        }

        // ou on peut mettre override au-dessus
        public override string ToString() // il faut mettre override car la class ToString et déjà défini dans le class string et comme on la redéfini, on met override
        {
            return Name+" "+LastName;
        }

        public abstract bool HasBirthday();
    }
}
