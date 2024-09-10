using System;

namespace TD1
{
    public class Ennemi
    {
        public int pointsAttaque { get; set; }
        public double vitesse{ get; set; }
        private int id { get; set; }
        public int vie { get; set; }
        public Ennemi() {
            vie = 100 ;
            vitesse = 5 ;
            pointsAttaque = 20 ;
        }
        public int attaque(bool crit = false){ //méthode
            //Si crit = true attaque plus puissante
            if (!crit)
            {
                Console.WriteLine("L'ennemi attaque : - "+ pointsAttaque) ;
                return pointsAttaque;
            }
            else
            {
                Console.WriteLine("L'ennemi reussi parfaitement et attaque : " + pointsAttaque * 1.5f);
                return Convert.ToInt32(pointsAttaque * 1.5f);
            }
        }
        public void defend (){ //méthode
            Console.WriteLine("L'ennemi se défend ") ;
        }
        public void incrementerPointAttaque(){ //méthode
            Console.WriteLine("L'ennemi prépare son attaque ! ") ;
            pointsAttaque++;
        }
    }
}