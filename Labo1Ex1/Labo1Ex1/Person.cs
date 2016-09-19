using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1Ex1
{
    class Person
    {
        //private String name; 
        //si majuscule(String) alors equals comme en java si minuscule(string) alors ==
        


        public string Name
        {
            get;
            set;
            /*
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
            */
        }

        private int age;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = (value > 0)? value : 1; // on met les conditions dans les set et get si on veut par exemple que ce soit positif
            }
        }


        public Person(String name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return Name+" âgé(e) de "+Age+" ans "; //Name = this.name en java
        }
    }
}
