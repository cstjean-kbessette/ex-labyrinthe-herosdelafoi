namespace Labyrinthe
{
    internal class View
    {

        public void AfficherLabyribnthe (Labyrinthe labyrinthe)
        {
            labyrinthe = new Labyrinthe (1,1);
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Console.Write(labyrinthe);
                }
                Console.WriteLine();
            }
        }
    
        
        public void AfficherEntete()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Bienvenue dans le Labyrinthe !");
            Console.WriteLine("Utilisez les flèches pour vous déplacer.");
            Console.WriteLine("Atteignez la sortie 'E' pour gagner !");
            Console.WriteLine("--------------------------------------------------------------------------------------\n");
        }

        public void AfficherVictoire()
        {
            Console.Clear();
            Console.WriteLine("Félicitations ! Vous avez trouvé la sortie !");
            Console.WriteLine("Merci d'avoir joué !");
            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}
