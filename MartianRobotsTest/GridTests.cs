using MartianRobots;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MartianRobotsTest
{
    [TestClass]
    public class GridTests
    {
        [TestMethod]
        public void CreateGrid()
        {
            Grid grid = new Grid(1, 1);
            Assert.IsNotNull(grid);
        }
    }
}
