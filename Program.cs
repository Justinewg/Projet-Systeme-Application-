using System;

namespace Projet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

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

                        Client nv_client = new Client(nom, prenom, num_tel, adr, date_pr_com, 0);

                    }
                    else if ((reponse = Console.ReadLine()) = 'N')
                    {
                        Console.WriteLine('Pouvez entrer votre numéro de téléphone svp.');
                        int num_tel = Console.ReadLine();
                    }
                }
            }
        }
    }
}


