using MartianRobots;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MartianRobotsTest
{
    [TestClass]
    public class RobotTests
    {
        private Grid TestGrid;

        [TestInitialize]
        public void Setup()
        {
            TestGrid = new Grid(10, 10);
        }

        [TestMethod]
        public void CreateValidRobot()
        {
            Robot robot = new Robot(TestGrid, 1, 1, Orientation.N, "");
            Assert.IsNotNull(robot);
        }

        [TestMethod]
        public void CreateInvalidRobot_InstructionLengthAboveMaxLimit_ThrowException()
        {
            Robot robot;
            Assert.ThrowsException<ArgumentException>(() => robot = new Robot(TestGrid, 1, 1, Orientation.N,
                "FFFFFFFFFRFFFFFFFFFRFFFFFFFFFRFFFFFFFFFRFFFFFFFFFRFFFFFFFFFRFFFFFFFFFRFFFFFFFFFRFFFFFFFFFRFFFFFFFFFR"));
        }
    }
}
