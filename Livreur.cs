using System;
namespace Projet
{
    public class Livreur
    {
        public int id_livreur;
        public string nom;
        public string prenom; 


        public Livreur()
        {
        }

        public Livreur(int id_livreur, string nom, string prenom)
        {
            this.id_livreur = id_livreur;
            this.nom = nom;
            this.prenom = prenom;
        }




    }
}
