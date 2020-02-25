using System.Collections.Generic;

namespace RoverChallenge
{
    public class GridHandler
    {
        public int X { get; set; }
        public int Y { get; set; }

        public GridHandler(List<int> values)
        {
            X = values[0] - 1;
            Y = values[1] - 1;
        }
        
        public bool IsInitialPositionValid(Coordinates location)
        {
            if (location.X <= X && location.Y <= Y)
                return true;

            return false;
        }

        public bool IsMoveValid(Coordinates currentLocation, string input)
        {
            if (input.ToUpper() == "L" || input.ToUpper() == "R")
            {
                return true;
            }

            if (input.ToUpper() == "M")
            {
                if (true)
                {

                }
                
                if (currentLocation.X > X)
                {

                }

                if (currentLocation.Y > Y)
                {

                }
            }

            return true;
        }

        public Coordinates MoveRover(Coordinates currentPosition, string input)
        {
            var newPosition = new Coordinates();



            return newPosition;
        }

        public string Rotate(bool clockwise, string currentDirection)
        {
            const string directions = "NESWN";

            if (clockwise)
            {
                var index = directions.IndexOf(currentDirection) + 1;

                return directions.Substring(index, 1);
            }
            else
            {
                if (currentDirection.ToUpper() == "N")
                    return "W";
                                
                var index = directions.IndexOf(currentDirection) - 1;
                return directions.Substring(index, 1);                
            }
        }
    }
}