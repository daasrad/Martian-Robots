using System;
using System.Collections.Generic;

namespace MartianRobots
{
    public class Grid
    {
        public const int MinimumGridSize = 0;
        public const int MaximumGridSize = 50;

        public Coordinates GridSize { get; }
        private List<Coordinates> ScentCoordinates;

        public Grid(int xSize, int ySize)
        {
            if(xSize < MinimumGridSize || ySize < MinimumGridSize || xSize > MaximumGridSize || ySize > MaximumGridSize)
            {
                throw new ArgumentException("Grid Size must be between 0 and 50");
            }

            this.GridSize = new Coordinates(xSize, ySize);
            this.ScentCoordinates = new List<Coordinates>();
        }

        public bool AreCoordinatesOffGrid(Coordinates coordinates)
        {
            return coordinates.X < MinimumGridSize || coordinates.Y < MinimumGridSize || coordinates.X > GridSize.X || coordinates.Y > GridSize.Y;
        }

        public void AddScent(Coordinates scentCoordinates)
        {
            ScentCoordinates.Add(scentCoordinates);
        }

        public bool HasScent(Coordinates coordinates)
        {
            return ScentCoordinates.Contains(coordinates);
        }
    }
}
