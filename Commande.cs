using System;



namespace Projet
{
    public class Commande
    {
        public int no_commande;
        public DateTime heure;
        public DateTime date_commande;
        public string nom_client;
        public string nom_commis;
        public string etat;


        public Commande(int no_commande, DateTime heure, DateTime date_commande, string nom_client, string nom_commis, string etat)
        {
            this.no_commande = no_commande;
            this.heure = heure;
            this.date_commande = date_commande;
            this.nom_client = nom_client;
            this.nom_commis = nom_commis;
            this.etat = etat;
        }
    }
}
