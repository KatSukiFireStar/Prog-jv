using System;

namespace TD1
{
    public class Boss
    {
        public int pointsAttaque; // Attribut
        private int id; // Attribut
        string nom; // Attribut
        int vitesse; // Attribut

        public Boss()
        {
            pointsAttaque = 200;
            int vitesse = 5; // Variable
            string code = nom + id; // Variable
            Console.WriteLine(code);
        }
    }
}