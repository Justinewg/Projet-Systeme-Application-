using System;
namespace Projet
{
    public class Facture
    {
        public int id_facture;
        public decimal prix;


        public Facture(int id_facture, decimal prix)
        {
            this.id_facture = id_facture;
            this.prix = prix;
        }


    }
}
