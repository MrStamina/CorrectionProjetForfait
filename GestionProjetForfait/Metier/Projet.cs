using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionProjetForfait.Metier
{
    public abstract class Projet
    {
        public int CodeProjet { get; set; }
        public string NomProjet { get; set; }
        public DateTime DDebut { get; set; }
        public DateTime DFin { get; set; }
        public Client LeClient { get; set; }
        public string Contact { get; set; }
        public string MailContact { get; set; }

        public abstract decimal CalculerCa();
        public abstract decimal CalculerMarge();


        public Projet(int code, string nomprojet, DateTime debut, DateTime fin, Client cli,
         string contact, string mailcontact)
        {
            this.CodeProjet = code;
            this.NomProjet = nomprojet;
            this.DDebut = debut;
            this.DFin = fin;
            this.LeClient = cli;
            this.Contact = contact;
            this.MailContact = mailcontact;

        }

        public Projet(string nomprojet, DateTime debut, DateTime fin, Client cli,
        string contact, string mailcontact)
        {
            this.NomProjet = nomprojet;
            this.DDebut = debut;
            this.DFin = fin;
            this.LeClient = cli;
            this.Contact = contact;
            this.MailContact = mailcontact;

        }

        // Equals : code identique
        public override bool Equals(Object obj)
        {
            if (obj is Projet)
                return
                   ((Projet)obj).CodeProjet.Equals(this.CodeProjet);
            else
                return false;
        }

        public override string ToString()
        {
            return "Projet [" + this.CodeProjet + "," + this.NomProjet + "," + this.DDebut.ToShortDateString() +
          "," + this.DFin.ToShortDateString() + "," + "\n" + this.LeClient + "\n," + this.Contact + "," + this.MailContact + "]";
        }


       

    }
}
