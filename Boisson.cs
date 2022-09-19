using System;
namespace Projet
{
    public class Boisson
    {
        public int id_boisson;
        public string type;
        public int volume;
        public decimal prix;


        public Boisson(int id_boisson, string type, int volume, decimal prix)
        {
            this.id_boisson = id_boisson;
            this.type = type;
            this.volume = volume;
            this.prix = prix;
        }

    }





}
