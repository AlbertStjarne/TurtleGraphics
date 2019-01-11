using System;
namespace _20_TurtleGraphics.Properties
{
    public class GameBoard
    {
        public const int GameBoardSize = 20;  //default size
        public const char UsedSpace = 'O';
        public const char GameBoardSymbol = '.';

        public GameBoard()
        {
            GameBoardArray = new char[GameBoardSize, GameBoardSize];
        }
        public static char[,] GameBoardArray { get; set; } //array to be updated with moves

        public static void UpdateGameBoardX(int start, int spacesToMove, int upOrDown, int constantY)
        {
            for (var i = 0; i < spacesToMove; i++)
            {
                GameBoardArray[start + (i * upOrDown), constantY] = UsedSpace;
            }
        }

        public static void UpdateGameBoardY(int start, int spacesToMove, int leftOrRight, int constantX)
        {
            for (var i = 0; i < spacesToMove; i++)
            {
                GameBoardArray[constantX, start + (i * leftOrRight)] = UsedSpace;
            }
        }

        public void DrawGameBoard(int posX, int posY, char turtle)
        {
            for (var i = 0; i < GameBoardSize; i++)
            {
                for (var c = 0; c < GameBoardSize; c++)
                {
                    if (i == posX && c == posY)
                        Console.Write(turtle);
                    else
                        Console.Write(GameBoardArray[i, c]);
                }
                Console.WriteLine();
            }
        }

        public void InitGameBoard()
        {
            for (var i = 0; i < GameBoardSize; i++)
            {
                for (var c = 0; c < GameBoardSize; c++)
                {
                    GameBoardArray[i, c] = GameBoardSymbol;
                }
            }
        }


    }
}
