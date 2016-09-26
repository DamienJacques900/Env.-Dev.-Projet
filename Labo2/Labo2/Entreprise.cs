using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class Entreprise
    {
        private String name;
        private String locality;

        public String Name
        {
            get;
            set;
        }

        public String Locality
        {
            get;
            set;
        }
        public Entreprise(String name, String locality)
        {
            Name = name;
            Locality = locality;
        }

        public override string ToString()
        {
            return "Nom : "+Name+"\nLocalité : "+Locality+"\n\n";
        }
    }
}
