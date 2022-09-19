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

        public Client(int id_client, string nom, string prenom, int num_telephone, string adresse, DateTime premiere_commande, int nombre_commande)
        {
            this.id_client = id_client;
            this.nom = nom;
            this.prenom = prenom;
            this.num_telephone = num_telephone;
            this.adresse = adresse;
            this.premiere_commande = premiere_commande;
            this.nombre_commande = nombre_commande;
        }


        public static boolean appel()
        {
            Console.WriteLine("Est-ce votre première commande? O / N");
            string reponse = Console.ReadLine();
            while (reponse != 'O' ^ reponse != 'N')
            {
                if ((reponse = Console.ReadLine()) = 'O')
                {
                    Console.WriteLine('Entrez votre nom de famille.');
                    string nom = Console.ReadLine();
                    Console.WriteLine('Entrez votre prénom.');
                    string prenom = Console.ReadLine();
                    Console.WriteLine('Entrez votre adresse.');
                    string adr = Console.ReadLine();
                    Console.WriteLine('Entrez votre numéro de téléphone.');
                    int num_tel = Console.ReadLine();
                    Console.WriteLine('Entrez la date de votre première commande.');
                    DateTime date_pr_com = Console.ReadLine();

                }
                else if ((reponse = Console.ReadLine()) = 'N')
                {
                    Console.WriteLine('Pouvez entrer votre numéro de téléphone svp.');
                    int num_tel = Console.ReadLine();
                }
            }
        }

        public static void nouveau_client(nom, prenom, adr, num_tel, date_pr_com)
        {

        }

}

}


