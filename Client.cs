using System;
namespace Projet
{
    public class Client
    {
        public int id_client;
        public string nom;
        public string prenom;
        public int num_telephone;
        public string adresse;
        public DateTime premiere_commande;
        public int nombre_commande;

        public Client(string nom, string prenom, int num_telephone, string adresse, DateTime premiere_commande, int nombre_commande)
        { 
            this.nom = nom;
            this.prenom = prenom;
            this.num_telephone = num_telephone;
            this.adresse = adresse;
            this.premiere_commande = premiere_commande;
            this.nombre_commande = nombre_commande;
        }


       

        public static void nouveau_client(nom, prenom, adr, num_tel, date_pr_com)
        {


        }

}

}


