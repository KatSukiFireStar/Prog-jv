using System;

namespace TD1
{
    public class Allie
    {
        public int pointsAttaque { get; set; }
        private int id { get; set; }
        public int vie { get; set; }
        
        public Allie()
        {
            //constructeur
            vie = 75;
            pointsAttaque = 10;
        }
        
        public int attaque(bool crit = false){ //méthode
            //Si crit = true attaque plus puissante
            if (!crit)
            {
                Console.WriteLine("L'allie attaque : - "+ pointsAttaque) ;
                return pointsAttaque;
            }
            else
            {
                Console.WriteLine("L'allie reussi parfaitement et attaque : " + pointsAttaque * 1.5f);
                return Convert.ToInt32(pointsAttaque * 1.5f);
            }
        }
        
        public void defendPersonnage (){ //méthode
            Console.WriteLine("L'allie vous defend!") ;
        }
        
        public void Heal(int healValue)
        {
            //Soigne de healValue l'allie
            if (vie >= 75)
            {
                Console.WriteLine("Vie au maximum ! Impossible de heal !");
                return;
            }
            
            Console.WriteLine("L'allie est soigne - " + healValue);
            vie += healValue;
        }
    }
}