using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProjetForfait.Metier
{
    public class Client
    {
        public int CodeClient { get; set; }
        public string RaisonSociale { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string CP { get; set; }
        public string Ville { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }

        // constructeur
        public Client() { }
        public Client(int code, string raisoc, string adr1, string adr2, string cp,string ville, 
            string telephone, string mail)
        {
            this.CodeClient = code;
            this.RaisonSociale = raisoc;
            this.Adresse1 = adr1;
            this.Adresse2 = adr2;
            this.CP = cp;
            this.Telephone = telephone;
            this.Mail = mail;
        }

        // Equals : Code  identique
        public override bool Equals(Object obj)
        {
            return obj is Client && ((Client) obj).CodeClient.Equals(this.CodeClient);
        }

        public override string ToString()
        {
            return String.Format("Client[{0}, {1}, {2}, {3}, {4}, {5}, {6}]", this.RaisonSociale, this.Adresse1, this.Adresse2, this.CP,this.Ville,
                this.Telephone, this.Mail);
        }

    }
}
