namespace justePrix;

class Program
{
    /*Jeu du juste prix*/ 
    static void Main(string[] args)
    {
        Console.WriteLine("Le juste prix");
 
        {
            bool recommencer = false;
            while (!recommencer)
            {

                //choix difficultée
                Console.WriteLine("choisissez une difficulté \n 1-Facile \n 2-Moyen \n 3-Difficile");
                int difficulte = int.Parse(Console.ReadLine());

                //nombre aléatoire
                int minimum = 1;
                int maximum = 0;

                if (difficulte == 1)
                {
                    maximum = 100;
                }

                if (difficulte == 2)
                {
                    maximum = 1000;
                }

                if (difficulte == 3)
                {
                    maximum = 10000;
                }

                Random random = new Random();
                int nombreAleatoire = random.Next(minimum, maximum + 1);

                //nombre utilisateur
                Console.WriteLine("Devinez le nombre : ");
                int nombreUtilisateur = int.Parse(Console.ReadLine());

                //comparaison
                bool gagne = false;

                //nombre de coups
                int compteur = 1;
                string reponse;
                while (!gagne)
                {

                    if (nombreUtilisateur > nombreAleatoire)
                    {
                        Console.WriteLine("Plus petit");
                        nombreUtilisateur = int.Parse(Console.ReadLine());
                        compteur++;
                    }

                    if (nombreUtilisateur < nombreAleatoire)
                    {
                        Console.WriteLine("Plus grand");
                        nombreUtilisateur = int.Parse(Console.ReadLine());
                        compteur++;
                    }

                    if (nombreUtilisateur == nombreAleatoire)
                    {
                        Console.WriteLine("Gagné ! \n En " + compteur + " coups.");
                        gagne = true;

                        Console.WriteLine("Voulez vous recommencer ? O/N");
                        reponse = Console.ReadLine();
                        if (reponse == "N")
                        {
                            recommencer = true;
                        }
                        
                    }
                }
            }
        }
    }
}

