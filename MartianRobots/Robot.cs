using System;

namespace MartianRobots
{
    public class Robot
    {
        private const int MaximumInstructionLength = 100;

        public Grid Grid { get; set; }
        public Coordinates CurrentCoordinates { get; set; }
        public Orientation Orientation { get; set; }
        public string Instruction { get; set; }

        public Robot(Grid grid, int positionX, int positionY, Orientation orientation, string instruction)
        {
            if(instruction.Length >= MaximumInstructionLength)
            {
                throw new ArgumentException("All instruction strings must be less than 100 characters in length.");
            }

            this.Grid = grid;
            this.CurrentCoordinates = new Coordinates(positionX, positionY);
            this.Orientation = orientation;
            this.Instruction = instruction;
        }

    }
}
