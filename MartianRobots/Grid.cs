using System;

namespace MartianRobots
{
    public class Grid
    {
        private int XSize { get; set; }
        private int YSize { get; set; }

        public Grid(int xSize, int ySize)
        {
            if(xSize > 50 || ySize > 50 || xSize < 0 || ySize < 0)
            {
                throw new ArgumentException("Grid Size must be between 0 and 50");
            }

            this.XSize = xSize;
            this.YSize = ySize;
        }
    }
}
