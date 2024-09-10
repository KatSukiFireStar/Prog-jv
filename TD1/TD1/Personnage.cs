using System;

namespace TD1
{
    public class Personnage
    {
        private int vie; //attribut
        private double vitesse; //attribut
        public int id; //attribut
        public int healPoint { get; set; }

        public Personnage()
        {
            //constructeur
            vie = 75;
            vitesse = 5;
            healPoint = 15;
        }

        public void Heal(bool crit = false)
        {
            //Si crit = true heal plus puissant
            if (vie >= 75)
            {
                Console.WriteLine("Vie au maximum ! Impossible de heal !");
                return;
            }
            if (!crit)
                Console.WriteLine("Je me soigne - " + healPoint);
            else
            {
                Console.WriteLine("Reussite critique!");
                Console.WriteLine("Je me soigne - " + healPoint * 1.5f);
            }
            vie += healPoint;

            if (vie >= 75)
            {
                vie = 75;
            }
        }

        public void marche()
        {
            //méthode
            Console.WriteLine("Je marche");
        }

        public void arrete()
        {
            //méthode
            Console.WriteLine("Je m’arrete");
        }

        public int getVie()
        {
            //méthode de type « get »
            return vie;
        }

        public void setVie(int nouvelleValeur)
        {
            //méthode de type « set »
            vie = nouvelleValeur;

        }
    }
}