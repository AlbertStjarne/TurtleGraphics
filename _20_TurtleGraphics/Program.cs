using System;
using _20_TurtleGraphics.Properties;

namespace _20_TurtleGraphics
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.GameLoop();

            Console.WriteLine("\nThanks for playing. Good Bye\n");  //final message
        }
    }
}
