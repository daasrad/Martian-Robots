using System;

namespace MartianRobots
{
    public class Robot
    {
        private const int MaximumInstructionLength = 100;

        public Grid Grid { get; set; }
        public Coordinates CurrentCoordinates { get; set; }
        public Orientation Orientation { get; set; }
        public string Instructions { get; set; }

        public Robot(Grid grid, int positionX, int positionY, Orientation orientation, string instructions)
        {
            if(instructions.Length >= MaximumInstructionLength)
            {
                throw new ArgumentException("All instruction strings must be less than 100 characters in length.");
            }

            this.Grid = grid;
            this.CurrentCoordinates = new Coordinates(positionX, positionY);
            this.Orientation = orientation;
            this.Instructions = instructions;
        }

        public void ExecuteInstructions()
        {
            foreach(char instruction in Instructions)
            {
                switch (instruction)
                {
                    case 'L':
                        throw new NotImplementedException();
                        break;
                    case 'R':
                        throw new NotImplementedException();
                        break;
                    case 'F':
                        MoveForward();
                        break;
                    default:
                        throw new NotSupportedException("Unsupported instruction: " + instruction);
                }
            }
        }

        private void MoveForward()
        {
            switch (this.Orientation)
            {
                case Orientation.N:
                    CurrentCoordinates.Y++;
                    break;
                case Orientation.S:
                    CurrentCoordinates.Y--;
                    break;
                case Orientation.E:
                    CurrentCoordinates.X++;
                    break;
                case Orientation.W:
                    CurrentCoordinates.X--;
                    break;
            }
        }
    }
}
