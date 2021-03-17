using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueAPP
{
    class Operation
    {
        private int num;
        private static int cpt;
       private DateTime now;
        private MAD montant;
        private string libele;
        static Operation()
        {
            cpt = 0;
        }
        public Operation()
        {

        }
public Operation(string lib,MAD mnt)
        {
            this.num = ++cpt;
           // this.dt = new DateTime();
            now = DateTime.Now;
            this.libele = lib;
            this.montant = mnt;

        }
        public void afficher()
        {
            Console.Write(this.libele+"||"+this.now + "|n°"+this.num+"||");
            this.montant.afficher();
        }
    }
}
