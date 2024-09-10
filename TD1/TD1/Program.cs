using System;

namespace TD1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //En debut de partie, le joueur choisi un nombre de tour et la
            //partie debute ensuite
            //Le programme simule une partie de jeu de role sur table
            //Pour chaque action un nombre aléatoire est tiré représentant
            //le lancer de dès du maitre du jeu ce nombre influe la partie comme suit:
            //  -1 : Reussite critique - action * 1.5
            //  -2 a 15 : Action normal
            //  -16 a 19 : Echec de l'action
            //  -20 : Echec critique - Degats pour l'utilisateur
            //
            //A chaque tour, le joueur choisit une action entre :
            //  -Se heal
            //  -Heal allié
            //  -Defense Allié + heal joueur
            //  -Attaque allié
            //A la fin de chaque tour l'ennemi attaquera soit le jouer soit l'allie en
            //fonction des choix du joueur
            //La partie se finit si le joueur est mort ou si l'ennemi meurt ou si le
            //nombre de tour est terminé
            
            Personnage monPerso = new Personnage();
            Ennemi ennemi1 = new Ennemi() ;
            Allie allie1 = new Allie() ;
            /*while(monPerso.getVie() > 0) {
                monPerso.marche();
                ennemi1.attaque() ;
                if (allie1.vie > 0)
                {
                    allie1.defendPersonnage();
                    allie1.attaque();
                }
                Console.WriteLine("Vie personnage :" + monPerso.getVie());
                Console.WriteLine("Vie allie :" + allie1.vie);
                Console.WriteLine("Vie ennemi :" + ennemi1.vie);
                Console.WriteLine("L’ennemi attaque :" + ennemi1.pointsAttaque);
                if(allie1.vie <= 0)
                    monPerso.setVie(monPerso.getVie() -20);
                else
                {
                    allie1.vie -= 20;
                    ennemi1.vie -= allie1.pointsAttaque;
                }
                
                ennemi1.incrementerPointAttaque() ;
            }
            Console.WriteLine("C'est fini. Game Over!");*/

            Console.WriteLine("Nombre de tours de jeu:");
            int nbTour = int.Parse(Console.ReadLine());
            Random random = new Random();
            while (monPerso.getVie() > 0 && ennemi1.vie > 0 && nbTour > 0)
            {
                Console.WriteLine("\nNombre de tours restants : " + nbTour);
                Console.WriteLine("Vie personnage : " + monPerso.getVie());
                Console.WriteLine("Vie allie : " + allie1.vie);
                Console.WriteLine("Vie ennemi : " + ennemi1.vie);
                
                Console.WriteLine("L'ennemi se prepare à attaquer !");
                int n;
                bool degatsPerso = true;
                Console.WriteLine("Que voulez vous faire?");
                if (allie1.vie > 0)
                {
                    Console.WriteLine("H : Heal personnage \nZ : Heal allie \nD : Defense allie \nA : Attaque Allie");
                }
                else
                {
                    Console.WriteLine("H : Heal personnage \nZ : Heal allie");
                }
                string line = Console.ReadLine();
                line = line.ToUpper();
                switch (line)
                {
                    case "H":
                        n = random.Next(1, 20);
                        Console.WriteLine("Le maitre du jeu lance son dé et tire un " + n);
                        if (n == 1)
                        {
                            monPerso.Heal(true);
                        }else if (n <= 15)
                        {
                            monPerso.Heal();
                        }else if (n < 20)
                        {
                            Console.WriteLine("Le heal ne marche pas!");
                        }
                        else
                        {
                            Console.WriteLine("Echec critique : vous perdez 5 pv !");
                            monPerso.setVie(monPerso.getVie() - 5);
                        }

                        break;
                    case "Z":
                        n = random.Next(1, 20);
                        Console.WriteLine("Le maitre du jeu lance son dé et tire un " + n);
                        if (n == 1)
                        {
                            allie1.Heal(Convert.ToInt32(monPerso.healPoint * 1.5f));
                        }else if (n <= 15)
                        {
                            allie1.Heal(monPerso.healPoint);
                        }else if (n < 20)
                        {
                            Console.WriteLine("Le heal ne marche pas!");
                        }
                        else
                        {
                            Console.WriteLine("Echec critique : l'allie perd 5 pv !");
                            allie1.vie -= 5;
                        }
                        break;
                    case "D":
                        if (allie1.vie <= 0)
                        {
                            break;
                        }
                        allie1.defendPersonnage();
                        degatsPerso = false;
                        
                        n = random.Next(1, 20);
                        Console.WriteLine("Le maitre du jeu lance son dé et tire un " + n);
                        if (n == 1)
                        {
                            monPerso.Heal(true);
                        }else if (n <= 15)
                        {
                            monPerso.Heal();
                        }else if (n < 20)
                        {
                            Console.WriteLine("Le heal ne marche pas!");
                        }
                        else
                        {
                            Console.WriteLine("Echec critique : vous perdez 5 pv !");
                            monPerso.setVie(monPerso.getVie() - 5);
                        }
                        break;
                    case "A":
                        if (allie1.vie <= 0)
                        {
                            break;
                        }

                        int degat = 0;
                        n = random.Next(1, 20);
                        Console.WriteLine("Le maitre du jeu lance son dé et tire un " + n);
                        if (n == 1)
                        {
                            degat = allie1.attaque(true);
                        }else if (n <= 15)
                        {
                            degat = allie1.attaque();
                        }else if (n < 20)
                        {
                            Console.WriteLine("L'allie rate son attaque!");
                        }
                        else
                        {
                            Console.WriteLine("L'allie rate son attaque et se prend son arme dans le pied!");
                            allie1.vie -= 5;
                        }
                        ennemi1.vie -= degat;
                        break;
                    default:
                        break;
                }

                int degats = 0;
                n = random.Next(1, 20);
                Console.WriteLine("Le maitre du jeu lance son dé et tire un " + n);
                if (n == 1)
                {
                    degats = ennemi1.attaque(true);
                }else if (n <= 15)
                {
                    degats = ennemi1.attaque();
                }else if (n < 20)
                {
                    Console.WriteLine("L'ennemi rate son attaque!");
                }
                else
                {
                    Console.WriteLine("L'ennemi rate son attaque et se prend son arme dans le pied!");
                    ennemi1.vie -= 5;
                }

                if (degatsPerso)
                {
                    monPerso.setVie(monPerso.getVie() - degats);
                }
                else
                {
                    allie1.vie -= degats;
                }
                nbTour--;
            }

            if (nbTour == 0 || ennemi1.vie <= 0)
            {
                Console.WriteLine("Vous avez survécu!");
            }else if (monPerso.getVie() <= 0)
            {
                Console.WriteLine("Vous etes mort!");
            }
        }
    }
    
}