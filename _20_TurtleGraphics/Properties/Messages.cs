using System;
namespace _20_TurtleGraphics.Properties
{
    public static class Messages
    {
        public static void Instructions()
        {
            Console.WriteLine("Type your commands to draw on the game board");
            Console.WriteLine("1 = pen up, 2 = pen down");
            Console.WriteLine("3 = North, 4 = East, 5 = South, 6 = West");
            Console.WriteLine("7 = Quit");
        }

        public static string ErrorMessage { get; set; }  //holds the current error messages

        public static void InvalidInput()
        {
            ErrorMessage = "\nINVALID INPUT. Input must be an integer between 1 - 7\n";
        }

        public static void InvalidMove(string direction, int spaces)
        {
            ErrorMessage = $"\nINVALID MOVE. You can only move {spaces} spaces to the {direction}\n";
        }

    }
}
