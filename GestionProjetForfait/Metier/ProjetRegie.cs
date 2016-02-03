using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionProjetForfait.Metier
{
    public class ProjetRegie : Projet
    { 
        public decimal TarifJournalier { get; set; }
        public Qualification Qualification { get; set; }

        public ProjetRegie(int code, string nomprojet, DateTime debut, DateTime fin, Client cli,
          string contact, string mailcontact, decimal tj,Qualification q ): base(code, nomprojet, debut, fin, cli, contact, mailcontact)
        {
            this.TarifJournalier=tj;
            this.Qualification=q;
       }
        public ProjetRegie(string nomprojet, DateTime debut, DateTime fin, Client cli,
         string contact, string mailcontact, decimal tj, Qualification q) : base( nomprojet, debut, fin, cli, contact, mailcontact)
        {
            this.TarifJournalier = tj;
            this.Qualification = q;
        }

        public override decimal CalculerCa()
        {
            // Nombre de jours ouvrés = Nb de semaines entre 2 dates * 5
            TimeSpan ts = DFin - DDebut;
            int nbS = ts.Days % 7;
            int nbj = nbS * 5 + (ts.Days - nbS * 7);
            return  nbj * TarifJournalier;
        }

        public override decimal CalculerMarge()
        {
            throw new NotImplementedException();
        }

         public override string ToString()
        {
            return base.ToString() + "[" + this.TarifJournalier +
          "," + this.Qualification + "]\n";
        }

    }
}
