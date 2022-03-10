using System;

namespace MartianRobots
{
    class Program
    {
        static void Main(string[] args)
        {
            Grid grid = new Grid(5, 3);

            Robot robotOne = new Robot(grid, 1, 1, Orientation.E, "RFRFRFRF");
            robotOne.ExecuteInstructions();
            Console.WriteLine(robotOne.GetStatus());

            Robot robotTwo = new Robot(grid, 3, 2, Orientation.N, "FRRFLLFFRRFLL");
            robotTwo.ExecuteInstructions();
            Console.WriteLine(robotTwo.GetStatus());

            Robot robotThree = new Robot(grid, 0, 3, Orientation.W, "LLFFFLFLFL");
            robotThree.ExecuteInstructions();
            Console.WriteLine(robotThree.GetStatus());

            Console.ReadLine();
        }
    }
}
