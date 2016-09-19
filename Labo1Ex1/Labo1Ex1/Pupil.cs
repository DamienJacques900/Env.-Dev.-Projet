using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1Ex1
{
    class Pupil : Person
    {
        public int Grade
        {
            get;
            set;
        }

        private List<Activity> listActivites;
        public List<Activity> ListActivites
        {
            get
            {
                return listActivites;
            }

            set
            {
                listActivites = value;
            }
        }

        private Parameter.enumEvaluation[] tabEval;
        public Parameter.enumEvaluation[] TabEval
        {
            get
            {
                return tabEval;
            }

            set
            {
                tabEval = value;
            }
        }

        public Pupil(String name, int age, int grade) : base(name, age)
        {
            Grade = grade;
            ListActivites = new List<Activity>();
            TabEval = new Parameter.enumEvaluation[Parameter.MAX];
        }
        
        public Pupil(String name, int age) : this(name, age, 1)
        { }

        public void AddActivity(Activity activity)
        {
            ListActivites.Add(activity);
        }

        public override string ToString()
        {
            string ch = base.ToString();
            int cptActivities = ListActivites.Count();
            if (cptActivities == 0)
            {
                ch += " n'a pas encore choisi d'activité";
            }
            else
            {
                ch += "a choisi les activités suivantes : \n";
                foreach (Activity activity in ListActivites)
                    ch += "\n"+ activity.ToString();
            }
            return ch;
        }

        public void AddEvaluation(String title = null, Parameter.enumEvaluation evaluation = Parameter.enumEvaluation.S)
        {
            var i = 0; // On peut utiliser des variables non typés. 
            while (i < ListActivites.Count() || ListActivites.ElementAt(i).Title.Equals(title))
                i++;  

            TabEval[i] = evaluation;    
        }
    }
}

//Raccourci encrire le début puis faire 2 fois tab =>snippet