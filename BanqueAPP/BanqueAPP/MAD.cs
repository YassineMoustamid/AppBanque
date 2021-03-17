using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueAPP
{
    class MAD
    {
        private double valeur;

        public MAD(double val)
        {
            this.valeur = val;
        }

        public void afficher()
        {
            Console.WriteLine("la valeur est :" + this.valeur);
        }

        public static  bool operator <(MAD a,MAD b)
        {
            return a.valeur < b.valeur;

        }

        public static bool operator >(MAD a, MAD b)
        {
            return a.valeur > b.valeur;

        }
        public static MAD operator +(MAD a, MAD b)
        {
            MAD res = new MAD(a.valeur + b.valeur);
            return res;
        }


        public static MAD operator *(MAD a, double b)
        {
            MAD res = new MAD(a.valeur * b);
            res.afficher();
            return res;
        }

        public static MAD operator -(MAD a, MAD b)
        {
            MAD res = new MAD(a.valeur -b.valeur);
            return res;
        }

    }
}
