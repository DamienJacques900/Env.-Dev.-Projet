using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil antoni = new Pupil("Antoni Maniscalo", 20, 1);
            Activity français = new Activity("Français",true);
            Activity math = new Activity("Mathématique",false);

            antoni.AddActivity(français);
            antoni.AddActivity(math);

            Activity coloriage = new Activity("Coloriage", true);

            Pupil pupil1 = new Pupil("Damien Jacques", 22, 1);
            Pupil pupil2 = new Pupil("Olivier Beguin", 21, 1);
            Pupil pupil3 = new Pupil("Louis Van Den Dorren", 20, 2);
            Pupil pupil4 = new Pupil("Augustin Willem", 5, 1);

            List<Pupil> listPupil = new List<Pupil>();

            listPupil.Add(antoni);
            listPupil.Add(pupil1);
            listPupil.Add(pupil2);
            listPupil.Add(pupil3);
            listPupil.Add(pupil4);

           /*
            var pupilGrade1Plus6 = from Pupil in listPupil
                                   where Pupil.Age > 5
                                   select Pupil.Name;
            */

            var pupilGrade1Plus6 = listPupil.TakeWhile(n => n.Age > 5);

            if (pupilGrade1Plus6!=null)
                System.Console.Write(pupilGrade1Plus6);



            antoni.AddActivity(coloriage);
            //antoni.AddEvaluation("Coloriage");
            //antoni.AddEvaluation(evaluation :'T', title:"Gym");


            System.Console.Write(antoni);

            //System.Console.Write(antoni.TabEval[2]);
             

            System.Console.Read();
        }
    }
}
