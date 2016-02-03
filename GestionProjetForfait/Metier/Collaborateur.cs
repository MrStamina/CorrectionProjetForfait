    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProjetForfait.Metier
{
    public class Collaborateur
    {
        public int CodeColl { get; set; }
        public string Nom { get; set; }
        public string PreNom { get; set; }
        public DateTime? DEmbauche { get; set; }
        public decimal PrJournalier { get; set; }
        public Qualification LaQualif { get; set; }

        // constructeur

        public Collaborateur() { }
        public Collaborateur(int code, string nom, string prenom, DateTime? dembauche,
             decimal prjour, Qualification qualif)
        {
            this.CodeColl = code;
            this.Nom = nom;
            this.PreNom = prenom;
            this.DEmbauche = dembauche;
            this.PrJournalier = prjour;
            //this.LeStatut = statut;
            this.LaQualif = qualif;
        }

        // Equals : Code  identique
        public override bool Equals(Object obj)
        {
            if (obj is Collaborateur)
                return
                   ((Collaborateur)obj).CodeColl.Equals(this.CodeColl);
            else
                return false;
        }

        public override string ToString()
        {
            return String.Format("Collaborateur[{0}, {1}, {2}, {3}]", this.Nom, this.PreNom,((DateTime)this.DEmbauche).ToShortDateString(),this.PrJournalier);
        }

    }
}
