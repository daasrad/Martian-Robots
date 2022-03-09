namespace MartianRobots
{
    public class Grid
    {
        private int XSize { get; set; }
        private int YSize { get; set; }

        public Grid(int xSize, int ySize)
        {
            this.XSize = xSize;
            this.YSize = ySize;
        }
    }
}
