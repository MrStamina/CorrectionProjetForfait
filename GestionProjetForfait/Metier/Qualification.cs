using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionProjetForfait.Metier
{
    public class Qualification
    {
        public sbyte CodeQualif { get; set; }
        public string Libelle { get; set; }
        public decimal PvJournee { get; set; }


        // constructeur
        public Qualification() { }
        public Qualification(sbyte code, string lib, decimal pvjour)
        {
            this.CodeQualif = code;
            this.Libelle = lib;
            this.PvJournee = pvjour;
        }
        // Equals : code  identique
        public override bool Equals(Object obj)
        {
            if (obj is Qualification)
                return
                   ((Qualification)obj).CodeQualif.Equals(this.CodeQualif);
            else
                return false;
        }

        public override string ToString()
        {
            //return String.Format("[{0}, {1}]", this.Nom, this.PvJournee);
            return this.Libelle;
        }

        public Qualification Self
        {
            get { return this; }
        }
    }
}
