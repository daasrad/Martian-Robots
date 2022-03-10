using MartianRobots;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MartianRobotsTest
{
    [TestClass]
    public class GridTests
    {
        [TestMethod]
        public void CreateValidGrid()
        {
            Grid grid = new Grid(1, 1);
            Assert.IsNotNull(grid);
        }

        [TestMethod]
        public void CreateInvalidGrid_SizeXAboveMaxLimit_ThrowException()
        {
            Grid grid;
            Assert.ThrowsException<ArgumentException>(() => grid = new Grid(51, 1));
        }

        [TestMethod]
        public void CreateInvalidGrid_SizeYAboveMaxLimit_ThrowException()
        {
            Grid grid;
            Assert.ThrowsException<ArgumentException>(() => grid = new Grid(1, 51));
        }

        [TestMethod]
        public void CreateInvalidGrid_SizeXBelowMinLimit_ThrowException()
        {
            Grid grid;
            Assert.ThrowsException<ArgumentException>(() => grid = new Grid(-1, 1));
        }

        [TestMethod]
        public void CreateInvalidGrid_SizeYBelowMinLimit_ThrowException()
        {
            Grid grid;
            Assert.ThrowsException<ArgumentException>(() => grid = new Grid(1, -1));
        }

        [TestMethod]
        public void GridScentAdded()
        {
            Grid grid = new Grid(1, 1);
            grid.AddScent(new Coordinates(1, 1));

            Assert.IsTrue(grid.HasScent(new Coordinates(1, 1)));
        }
    }
}
