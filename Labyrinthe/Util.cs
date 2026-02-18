namespace Labyrinthe;

public class Util
{
        public static ConsoleKeyInfo LireTouche()
        {
            while (true)
            {
                try
                {
                    return Console.ReadKey(true);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }    
}