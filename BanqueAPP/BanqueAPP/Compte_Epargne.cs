using System;

namespace BanqueAPP
{
    class Compte_Epargne : Compte
    {
        private double taux_interet;

        Exception e;
        public Compte_Epargne(Client titu, MAD somme, double taux_interet)
            : base(titu, somme)
        {
            
            try
            {
                if (taux_interet > 100 || taux_interet < 0)
                    throw e;
                   
            }
            catch(Exception e) {
                //
                throw e;
            }
            if (taux_interet > 100 || taux_interet < 0)

                throw new Exception("Taux  Intrer invalide");
            else

            this.taux_interet = taux_interet;
        }

        public void calcule_interet()
        {
            this.solde = this.solde * (1 + this.taux_interet / 100);
        }

    }
}
