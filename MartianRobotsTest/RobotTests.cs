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

        [TestMethod]
        public void RobotExecutesInstructions()
        {
            Robot robot = new Robot(TestGrid, 1, 1, Orientation.N, "F");

            robot.ExecuteInstructions();

            Assert.AreEqual(2, robot.CurrentCoordinates.Y);
        }

        [TestMethod]
        public void RobotDoesNotExecutesInvalidInstructions()
        {
            Robot robot = new Robot(TestGrid, 1, 1, Orientation.N, "T");

            Assert.ThrowsException<NotSupportedException>(() => robot.ExecuteInstructions());
        }

        [TestMethod]
        public void MoveRobotForward_FacingNorth()
        {
            Robot robot = new Robot(TestGrid, 1, 1, Orientation.N, "F");

            robot.ExecuteInstructions();

            Assert.AreEqual(2, robot.CurrentCoordinates.Y);
        }

        [TestMethod]
        public void MoveRobotForward_FacingSouth()
        {
            Robot robot = new Robot(TestGrid, 1, 1, Orientation.S, "F");

            robot.ExecuteInstructions();

            Assert.AreEqual(0, robot.CurrentCoordinates.Y);
        }

        [TestMethod]
        public void MoveRobotForward_FacingEast()
        {
            Robot robot = new Robot(TestGrid, 1, 1, Orientation.E, "F");

            robot.ExecuteInstructions();

            Assert.AreEqual(2, robot.CurrentCoordinates.X);
        }

        [TestMethod]
        public void MoveRobotForward_FacingWest()
        {
            Robot robot = new Robot(TestGrid, 1, 1, Orientation.W, "F");

            robot.ExecuteInstructions();

            Assert.AreEqual(0, robot.CurrentCoordinates.X);
        }

        [TestMethod]
        public void TurnRobotLeft_FacingNorth()
        {
            Robot robot = new Robot(TestGrid, 1, 1, Orientation.N, "L");

            robot.ExecuteInstructions();

            Assert.AreEqual(Orientation.W, robot.Orientation);
        }

        [TestMethod]
        public void TurnRobotLeft_FacingSouth()
        {
            Robot robot = new Robot(TestGrid, 1, 1, Orientation.S, "L");

            robot.ExecuteInstructions();

            Assert.AreEqual(Orientation.E, robot.Orientation);
        }

        [TestMethod]
        public void TurnRobotLeft_FacingEast()
        {
            Robot robot = new Robot(TestGrid, 1, 1, Orientation.E, "L");

            robot.ExecuteInstructions();

            Assert.AreEqual(Orientation.N, robot.Orientation);
        }

        [TestMethod]
        public void TurnRobotLeft_FacingWest()
        {
            Robot robot = new Robot(TestGrid, 1, 1, Orientation.W, "L");

            robot.ExecuteInstructions();

            Assert.AreEqual(Orientation.S, robot.Orientation);
        }

        [TestMethod]
        public void TurnRobotRight_FacingNorth()
        {
            Robot robot = new Robot(TestGrid, 1, 1, Orientation.N, "R");

            robot.ExecuteInstructions();

            Assert.AreEqual(Orientation.E, robot.Orientation);
        }

        [TestMethod]
        public void TurnRobotRight_FacingSouth()
        {
            Robot robot = new Robot(TestGrid, 1, 1, Orientation.S, "R");

            robot.ExecuteInstructions();

            Assert.AreEqual(Orientation.W, robot.Orientation);
        }

        [TestMethod]
        public void TurnRobotRight_FacingEast()
        {
            Robot robot = new Robot(TestGrid, 1, 1, Orientation.E, "R");

            robot.ExecuteInstructions();

            Assert.AreEqual(Orientation.S, robot.Orientation);
        }

        [TestMethod]
        public void TurnRobotRight_FacingWest()
        {
            Robot robot = new Robot(TestGrid, 1, 1, Orientation.W, "R");

            robot.ExecuteInstructions();

            Assert.AreEqual(Orientation.N, robot.Orientation);
        }

        [TestMethod]
        public void RobotAddsScent_GoingOffGridFacingNorth()
        {
            Robot robot = new Robot(TestGrid, 5, 10, Orientation.N, "F");

            robot.ExecuteInstructions();

            Assert.IsTrue(TestGrid.HasScent(new Coordinates(5, 10)));
        }

        [TestMethod]
        public void RobotAddsScent_GoingOffGridFacingSouth()
        {
            Robot robot = new Robot(TestGrid, 5, 0, Orientation.S, "F");

            robot.ExecuteInstructions();

            Assert.IsTrue(TestGrid.HasScent(new Coordinates(5, 0)));
        }

        [TestMethod]
        public void RobotAddsScent_GoingOffGridFacingEast()
        {
            Robot robot = new Robot(TestGrid, 10, 5, Orientation.E, "F");

            robot.ExecuteInstructions();

            Assert.IsTrue(TestGrid.HasScent(new Coordinates(10, 5)));
        }

        [TestMethod]
        public void RobotAddsScent_GoingOffGridFacingWest()
        {
            Robot robot = new Robot(TestGrid, 0, 5, Orientation.W, "F");

            robot.ExecuteInstructions();

            Assert.IsTrue(TestGrid.HasScent(new Coordinates(0, 5)));
        }
    }
}
