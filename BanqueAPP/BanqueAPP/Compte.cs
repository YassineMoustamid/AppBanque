using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueAPP
{
    class Compte
    {
        private  readonly int numcomp;
        private static int cpt;
        private  readonly Client titulaire;
        protected MAD solde;
        protected  static MAD plafond;
        private Operation[] op;
       // List<Operation> op = new List<Operation>();
         static Compte()
        {
            cpt = 0;
            plafond = new MAD(2000);

        }
        public Compte(Client titu, MAD somme)
        {
            this.numcomp = ++cpt;
            this.titulaire = titu;
            this.solde = somme;
            op = new Operation[2];
        }
        public Compte()
        {

        }
        public void consulter()
        {
            int j;
            Console.WriteLine("le num est :" + this.numcomp);
            this.titulaire.afficher();
            this.solde.afficher();
            for(j=0;j<op.Length;j++)
            {if(op[j]!=null)
               op[j].afficher();
            }
        }
        int i = 0;
        public  virtual bool crediter(MAD somme)
        {
            
            MAD valnul = new MAD(0);
            if (somme > valnul)
            {
                this.solde += somme;
                
                Operation o = new Operation("crediter", somme);
                op[i] = o;
                //op[i].afficher();
                i++;
                return true;
            }
             return false;
        }

        public virtual bool debiter(MAD somme)
        {
            MAD valnul = new MAD(0);
            if (somme > valnul )
            {
                if(plafond > somme)
                {
                    if(this.solde > somme)
                    { 
                       
                           this.solde -= somme;
                        Operation o = new Operation("debiter", somme);
                        op[i] = o;
                       // op[i].afficher();
                        i++;
                        return true;
                    }
                    else {
                        Console.WriteLine("somme > solde ");
                        return false;
                    }
                }
                    else
                    {
                        Console.WriteLine("somme > plafond ");
                        return false;

                    }
            }
            else
                    {
                        Console.WriteLine("somme  invalide ");
                        return false;
                    }

        }

        public bool verser(Compte c, MAD somme)
        {
            if (this.debiter(somme))
            {
                c.crediter(somme);
                return true;
            }
            return false;


        }






    }
}





