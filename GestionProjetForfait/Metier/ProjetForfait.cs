using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionProjetForfait.Metier
{
    public class ProjetForfait : Projet
    {
        public decimal MontantContrat{ get; set; }
        public Penalite PenaliteOuiNon { get; set; }
        public Collaborateur ChefDeProjet{ get; set; }
        private List<Prevision> previsions;

        // constructeurs

        public ProjetForfait(int code, string nomprojet, DateTime debut, DateTime fin, Client cli,
         string contact, string mailcontact, decimal mtc, Penalite cp, Collaborateur chef): base(code, nomprojet,  debut,  fin,  cli, contact,  mailcontact)
        {
            this.MontantContrat = mtc;
            this.ChefDeProjet = chef;
            this.PenaliteOuiNon = cp;
            this.previsions = new List<Prevision>();
        }
        public ProjetForfait(int code, string nomprojet, DateTime debut, DateTime fin, Client cli,
          string contact, string mailcontact, decimal mtc,Penalite cp,Collaborateur chef,  List<Prevision> p ): base(code, nomprojet,  debut,  fin,  cli, contact,  mailcontact)
        {
        
            this.MontantContrat = mtc;
            this.ChefDeProjet = chef;
            this.previsions = p;
            this.PenaliteOuiNon = cp;
       }

        public ProjetForfait( string nomprojet, DateTime debut, DateTime fin, Client cli,
        string contact, string mailcontact, decimal mtc, Penalite cp, Collaborateur chef) : base( nomprojet, debut, fin, cli, contact, mailcontact)
        {
            this.MontantContrat = mtc;
            this.ChefDeProjet = chef;
            this.PenaliteOuiNon = cp;
        }
        // méthodes substituées
        public override decimal CalculerCa()
        {
            return MontantContrat;
        }
        public override decimal CalculerMarge()
        {
            throw new NotImplementedException();
        }

        // méthode spécialisée
        public int CalculerChargeAffectée()
        {
            return  previsions.Sum(p => p.NbJours);
        }

        public List<Prevision> GetPrevisions()
        {
            return previsions;
        }
        public void SetPrevisions(List<Prevision> lesPrev)
        {
            previsions = lesPrev;
        }
        public bool DelPrevision(Prevision pr)
        {
            try
            {
                previsions.Remove(pr);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdPrevision(Prevision pr)
        {
            // Recherche dans la liste
            int rang = previsions.IndexOf(pr);
            if (rang != -1)
            {
                previsions[rang] = pr;
                return true;
            }
            else return false;
        }

        public bool AddPrevision(Prevision pr)
        {
            previsions.Add(pr);
            return true;
        }

     

        public override string ToString()
        {
            return base.ToString() + "\n[" 
           + this.MontantContrat + "," + this.ChefDeProjet + "," + this.PenaliteOuiNon + "]\n";
        }


    }
}

