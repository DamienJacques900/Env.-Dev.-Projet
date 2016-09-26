using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class Car
    {
        private String plaqueNumber;

        public String PlaqueNumber
        {
            get;
            set;
        }

        public Car(String plaqueNumber)
        {
            PlaqueNumber = plaqueNumber;
        }

        public String ToString()
        {
            return "Le numéro de plaque est : " + PlaqueNumber;
        }
    }
}
