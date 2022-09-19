using System;
namespace Projet
{
    public class Commis
    {
        public int id_commis;
        public string nom;
        public string prenom;


        public Commis(int id_commis, string nom, string prenom)
        {
            this.id_commis = id_commis;
            this.nom = nom;
            this.prenom = prenom;
        }
    }


}
