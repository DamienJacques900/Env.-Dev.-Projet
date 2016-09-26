using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateBirthdayDamien = new DateTime(1994,9,26);

            PrivateContact antoni = new Labo2.PrivateContact("Antoni","Maniscalco","0458/65 67 47","antoni.maniscalco@gmail.com");
            PrivateContact damien = new Labo2.PrivateContact("Damien", "Jacques", "0458/45 78 12", "damien.jacques@gmail.com", dateBirthdayDamien);

            if(antoni.HasBirthday())
                System.Console.Write(antoni);
            if(damien.HasBirthday())
                System.Console.Write(damien+"\n");

            Entreprise microsoft = new Entreprise("Microsoft", "Chicago");
            Entreprise carrefour = new Entreprise("Carrefour", "Paris");

            List<Entreprise> listOli = new List<Entreprise>();
            List<Entreprise> listLouis = new List<Entreprise>();

            ProfesionalContact olivier = new ProfesionalContact("Olivier","Beguin","Consultant","0458/12 52 58","olivier.beguin.professionel@gmail.com", listOli);
            ProfesionalContact louis = new ProfesionalContact("Louis", "Van DenDorren", "Consultant", "0458/54 78 96", "louis.vandendorren.professionel@gmail.com", listLouis);
            ProfesionalContact augu = new ProfesionalContact("Augustin", "Willem", "Indépendant", "0458/78 36 54", "augustin.willem.professionel@gmail.com");

            olivier.ListEntreprise.Add(microsoft);
            olivier.ListEntreprise.Add(carrefour);

            louis.ListEntreprise.Add(microsoft);

            List<ProfesionalContact> listPro = new List<ProfesionalContact>();
            listPro.Add(olivier);
            listPro.Add(louis);
            listPro.Add(augu);

            var listIndépendant = from profesionalContact in listPro
                                  where profesionalContact.Job == "Indépendant"
                                  select profesionalContact;
            System.Console.Write(listIndépendant.Count()+"\n\n");
            if (listIndépendant != null)
            {
                foreach(ProfesionalContact element in listIndépendant)
                    System.Console.Write(element + "\n\n");
            }
            
            

            var listMicrosoft = listPro.Where(indép => indép.Job == "Consultant" && indép.ListEntreprise.Contains(microsoft));

            if (listMicrosoft != null)
            {
                foreach(ProfesionalContact element in listMicrosoft)
                    System.Console.Write(element + "\n\n");
            }

            Car voiture1 = new Car("1-EDZ-658");
            ContactCar guts = new ContactCar(voiture1);

            Car voiture2 = new Labo2.Car("1-PME-412");
            ContactCar augustin = new ContactCar(voiture2);

            guts.DynamicPrint(antoni);

            augustin.DynamicPrint(olivier);

            System.Console.Read();
        }
    }
}
