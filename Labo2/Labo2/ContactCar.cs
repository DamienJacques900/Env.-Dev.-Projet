using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class ContactCar
    {
        private Person person;
        private Car car;

        public Car Car
        {
            get;
            set;
        }

        public Person Person
        {
            get;
            set;
        }

        public ContactCar(Person person, Car car)
        {
            Person = person;
            Car = car;
        }

        public ContactCar(Car car)
        {
            Car = car;
        }

        public void DynamicPrint(dynamic objet)
        {
            System.Console.Write(objet.Print()+" voiture : "+Car.ToString()+"\n");
        }
    }
}
