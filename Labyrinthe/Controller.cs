namespace Labyrinthe
{
    internal class Controller
    {
        private View view;
        private Labyrinthe labyrinthe;

        public Controller(Labyrinthe labyrinthe, View view)
        {
            this.labyrinthe = labyrinthe;
            this.view = view;
        }

        public void MainController()
        {
            while (!labyrinthe.IsExit())
            {
                view.AfficherEntete();
                view.AfficherLabyrinthe(labyrinthe);
                ConsoleKeyInfo touche = Util.LireTouche();
                switch (touche.Key)
                {
                    case ConsoleKey.UpArrow:
                        labyrinthe.MoveUp();
                        break;
                    case ConsoleKey.DownArrow:
                        labyrinthe.MoveDown();
                        break;
                    case ConsoleKey.LeftArrow:
                        labyrinthe.MoveLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        labyrinthe.MoveRight();
                        break;
                    default:
                        break;
                }
            }
            view.AfficherVictoire();
        }
    }
}
