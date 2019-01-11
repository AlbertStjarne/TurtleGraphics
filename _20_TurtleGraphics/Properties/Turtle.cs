using System;
namespace _20_TurtleGraphics.Properties
{
    public class Turtle
    {
        public Turtle()
        {
            TurtleSymbol = 'X';
            PositionX = 0;
            PositionY = 0;
        }

        public char TurtleSymbol { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public void Walk(Directions.TurtleDirections direction, int spaces, Pen.PenActions pen)
        {
            if (ValidateMove(direction, spaces))
            {
                var toDraw = (pen == Pen.PenActions.Down);

                switch (direction)
                {
                    case Directions.TurtleDirections.North:
                        if (toDraw)
                            GameBoard.UpdateGameBoardX(PositionX, spaces, -1, PositionY);
                        PositionX -= spaces;
                        break;
                    case Directions.TurtleDirections.South:
                        if (toDraw)
                            GameBoard.UpdateGameBoardX(PositionX, spaces, 1, PositionY);
                        PositionX += spaces;
                        break;
                    case Directions.TurtleDirections.East:
                        if (toDraw)
                            GameBoard.UpdateGameBoardY(PositionY, spaces, 1, PositionX);
                        PositionY += spaces;
                        break;
                    case Directions.TurtleDirections.West:
                        if (toDraw)
                            GameBoard.UpdateGameBoardY(PositionY, spaces, -1, PositionX);
                        PositionY -= spaces;
                        break;

                }
            }
        }

        private bool ValidateMove(Directions.TurtleDirections direction, int spaces)
        {
            if (direction == Directions.TurtleDirections.North && (PositionX - spaces) < 0)
            {
                Messages.InvalidMove(direction, PositionX);
                return false;
            }

            if (direction == Directions.TurtleDirections.East && (PositionY + spaces) > GameBoard.GameBoardSize - 1)
            {
                Messages.InvalidMove(direction, GameBoard.GameBoardSize - PositionY - 1);
                return false;
            }

            if (direction == Directions.TurtleDirections.South && (PositionX + spaces) > GameBoard.GameBoardSize - 1)
            {
                Messages.InvalidMove(direction, GameBoard.GameBoardSize - PositionX - 1);
                return false;
            }

            if (direction == Directions.TurtleDirections.West && (PositionY - spaces) < 0)
            {
                Messages.InvalidMove(direction, PositionY);
                return false;
            }

            return true;
        }


    }
}
