using System;
using System.Collections.Generic;
using System.Linq;

namespace RoverChallenge
{
    class Program
    {
        public static GridHandler Grid { get; set; }
        public List<Rover> Rovers { get; set; }

        static void Main(string[] args)
        {
            InitialiseGrid(args);

            ProcessRoverInput();


            // Move rovers

            // Output new position


            var newDirection = Grid.Rotate(false, "N");

            string a = "d";
        }

        public static void InitialiseGrid(string[] args)
        {
            var input = Console.ReadLine();

            var gridSizes = InputHandler.GetGridValues(input);

            if (gridSizes == null)
            {
                Console.WriteLine("Invalid input");
                Main(args);
            }

            Grid = new GridHandler(gridSizes);
        }

        public static void ProcessRoverInput()
        {
            var firstRoverPosition = Console.ReadLine();


        }
    }
}