using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BanqueAPP
{
    class Client
    {
        private  string nom;
        private  string prenom;
        private  string adressse;
        private List<Compte> listeCompte;

        public Client(string n,string p,string a)
        {
            this.nom = n;
            this.prenom= p;
            this.adressse= a;
            listeCompte = new List<Compte>();
        }

        public void afficher()
        {

            Console.WriteLine("le nom est :" + this.nom);
            Console.WriteLine("le prenom est :" + this.prenom);
            Console.WriteLine("l'adresse est :" + this.adressse);
        }
    }
}
