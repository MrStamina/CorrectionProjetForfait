using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProjetForfait.Metier
{
    public class Prevision
    {
        public int CodePrev { get; set; }
        public int CodeProjet { get; set; }
        public Qualification LaQualif { get; set; }
        public short NbJours { get; set; }

          // constructeur
        public Prevision()
        {
        }
        public Prevision(Qualification oQ, short nbj)
        {
            this.LaQualif = oQ;
            this.NbJours = nbj;
        }

        // Equals : code  identique
        public override bool Equals(Object obj)
        {
            if (obj is Prevision)
                return
                    ((Prevision) obj).LaQualif.Equals(this.LaQualif);
            else
                return false;
        }

        public override string ToString()
        {
            return String.Format("Prévision[{0}, {1}]", this.LaQualif, this.NbJours);
        }

    }
}
