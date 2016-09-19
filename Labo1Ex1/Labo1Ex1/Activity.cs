using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1Ex1
{
    class Activity
    {

        public string Title
        {
            get;
            set;
        }
        //Si on ne doit pas modifier ni le get ni le set alors
        //on fait get; set; car la variable est déjà en private
        //et donc pas besoin de l'écrire avant comme dans la classe
        //Person avec l'âge. Dans âge on fait un set spécial et 
        //donc on met le private avant et le code complet.
        public bool Compulsary
        {
            get;
            set;
        }

        public Activity(String title, bool compulsary)
        {
            Title = title;
            Compulsary = compulsary;
        }

        public string ToString()
        {
            return (Compulsary == true) ? Title + " (obligatoire)" : Title;
        }
    }
}
