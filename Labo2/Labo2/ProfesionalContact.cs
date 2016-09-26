using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class ProfesionalContact : Person
    {
        private String job;
        private String phoneNumberJob;
        private String mailJob;
        private List<Entreprise> listEntreprise;

        public List<Entreprise> ListEntreprise
        {
            get;
            set;
        }

        public String Job
        {
            get;
            set;
        }

        public String PhoneNumberJob
        {
            get;
            set;
        }

        public String MailJob
        {
            get;
            set;
        }
        public ProfesionalContact(String name,String lastName, String job, String phoneNumberJob, String mailJob) : base(name,lastName)
        {
            Job = job;
            PhoneNumberJob = phoneNumberJob;
            MailJob = mailJob;
        }
        public ProfesionalContact(String name, String lastName, String job, String phoneNumberJob, String mailJob, List<Entreprise> listEntreprise) : base(name, lastName)
        {
            Job = job;
            PhoneNumberJob = phoneNumberJob;
            MailJob = mailJob;
            ListEntreprise = listEntreprise;
        }


        public override string ToString()
        {
            return base.ToString()+"("+PhoneNumberJob+")\n"+Job+"\n"+MailJob+"\n\n";
        }

        public override bool HasBirthday()
        {
            return false;
        }

        public void EntrepriseAdd(Entreprise entr)
        {
            ListEntreprise.Add(entr);
        }

        public String Print()
        {
            return Name + " " + LastName + " est un contact professionnel";
        }
    }
}
