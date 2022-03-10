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
        public bool IsLost { get; set; }

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
            this.IsLost = Grid.AreCoordinatesOffGrid(CurrentCoordinates);
        }

        public void ExecuteInstructions()
        {
            foreach(char instruction in Instructions)
            {
                if (IsLost)
                {
                    break;
                }

                switch (instruction)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'F':
                        MoveForward();
                        break;
                    default:
                        throw new NotSupportedException("Unsupported instruction: " + instruction);
                }
            }
        }

        private void TurnLeft()
        {
            switch (this.Orientation)
            {
                case Orientation.N:
                    this.Orientation = Orientation.W;
                    break;
                case Orientation.S:
                    this.Orientation = Orientation.E;
                    break;
                case Orientation.E:
                    this.Orientation = Orientation.N;
                    break;
                case Orientation.W:
                    this.Orientation = Orientation.S;
                    break;
            }
        }

        private void TurnRight()
        {
            switch (this.Orientation)
            {
                case Orientation.N:
                    this.Orientation = Orientation.E;
                    break;
                case Orientation.S:
                    this.Orientation = Orientation.W;
                    break;
                case Orientation.E:
                    this.Orientation = Orientation.S;
                    break;
                case Orientation.W:
                    this.Orientation = Orientation.N;
                    break;
            }
        }

        private void MoveForward()
        {
            if(!Grid.HasScent(CurrentCoordinates))
            {
                Coordinates previousCoordinates = new Coordinates(CurrentCoordinates.X, CurrentCoordinates.Y);

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

                if (Grid.AreCoordinatesOffGrid(CurrentCoordinates))
                {
                    Grid.AddScent(previousCoordinates);
                    IsLost = true;
                }
            }
        }
    }
}
