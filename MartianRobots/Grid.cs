using System;

namespace MartianRobots
{
    public class Grid
    {
        private const int MinimumGridSize = 0;
        private const int MaximumGridSize = 50;

        private readonly Coordinates GridSize;

        public Grid(int xSize, int ySize)
        {
            if(xSize < MinimumGridSize || ySize < MinimumGridSize || xSize > MaximumGridSize || ySize > MaximumGridSize)
            {
                throw new ArgumentException("Grid Size must be between 0 and 50");
            }

            GridSize = new Coordinates(xSize, ySize);
        }
    }
}
