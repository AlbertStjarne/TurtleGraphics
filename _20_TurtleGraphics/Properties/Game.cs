using System;
namespace _20_TurtleGraphics.Properties
{
    public class Game
    {
        private Pen.PenActions _pen;
        private Directions.TurtleDirections _direction;
        private Turtle _turtle;
        private GameBoard _gameBoard;
        private bool _quit;  //quit the game
        private int _option;

        public Game()
        {
            _turtle = new Turtle();
            _gameBoard = new GameBoard();
            _quit = false;
            _pen = Pen.PenActions.Up;
            _direction = Directions.TurtleDirections.South;

        }

        public void GameLoop()
        {
            _gameBoard.InitGameBoard();

            do
            {
                Console.Clear();  //prepare screen for next display
                Console.WriteLine(Messages.ErrorMessage);  //display any erro message (or blank if no error message)
                Messages.ErrorMessage = "";  //reset error message for next input
                _gameBoard.DrawGameBoard(_turtle.PositionX, _turtle.PositionY, _turtle.TurtleSymbol);
                Messages.Instructions();  //display game instructions
                Console.WriteLine("Pen is " + (_pen == Pen.PenActions.Down ? "DRAWING" : "NOT DRAWING"));
                Console.WriteLine($"Turtle is moving {_direction}");  //display what direction was selected
                Console.WriteLine("Select your option: ");

                if (int.TryParse(Console.ReadLine(), out _option))  //make sure input is an integer
                {
                    if (_option > 0 && _option < 3)
                    {
                        _pen = (Pen.PenActions)_option;
                    }
                    else if (_option > 2 && _option < 7)
                    {
                        _direction = (Directions.TurtleDirections)_option;
                        Console.WriteLine($"Turtle is moving {_direction}");  //display what direction was selected
                        Console.WriteLine("Enter number of spaces to move: ");
                        int spaces;
                        if (int.TryParse(Console.ReadLine(), out spaces))
                        {
                            _turtle.Walk(_direction, spaces, _pen);

                        }
                        else
                            Messages.InvalidInput();
                    }
                    else if (_option == 7)
                    {
                        _quit = true;
                    }
                    else
                        Messages.InvalidInput();
                }
                else
                    Messages.InvalidInput();


            } while (!_quit);
        }

    }
}
