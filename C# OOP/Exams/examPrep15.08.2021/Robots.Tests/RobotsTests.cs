namespace Robots.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    public class RobotsTests
    {
        private Robot robot;
        private RobotManager robotManager;
        private const string name = "bako";
        private const int battery = 10;
        private const int Capacity = 1;

        [SetUp]
        public void SetUp()
        {
            robot = new Robot(name, battery);
            robotManager = new RobotManager(Capacity);
            robotManager.Add(robot);
        }

        [Test]
        public void Constructor_ShouldWorkProperly()
        {
            int expected = Capacity;
            Assert.AreEqual(expected, robotManager.Capacity);
        }

        [Test]
        public void Constructor_ShoulThrowExceptionIfCapacityBelowZero()
        {
            Assert.Throws<ArgumentException>(() => robotManager = new RobotManager(-2));
        }


        [Test]
        public void AddRobot_ShouldThrowException_WhenRobotExists() 
        {
            robotManager = new RobotManager(4);
            robot = new Robot("bace", 77);
            robotManager.Add(robot);
            Assert.Throws<InvalidOperationException>(() => robotManager.Add(robot));
        }

        [Test]
        public void RemoveRobot_ShouldWorkProperly()
        {
            int expected = 0;
            robotManager.Remove("bako");
            Assert.AreEqual(expected, robotManager.Count);
        }

        [Test]
        public void RemoveRobot_ShouldThrowException_WhenRobotIsNull()
        {
            Assert.Throws<InvalidOperationException>(() => robotManager.Remove("az"));
        }

        [Test]
        public void WorkRobot_ShouldThrowException_WhenRobotNull()
        {
            Assert.Throws<InvalidOperationException>(() => robotManager.Work("az", "box", 15));
        }

        [Test]
        public void WorkRobot_ShouldThrowException_WhenBatteryIsLessThanUsage()
        {
            Assert.Throws<InvalidOperationException>(() => robotManager.Work("bako", "box", 15));
        }

        [Test]
        public void WorkRobot_ShouldWorkProperly()
        {
            int expected = robot.Battery - 5;
            robotManager.Work("bako", "box", 5);
            Assert.AreEqual(expected, robot.Battery);
        }

        [Test]
        public void ChargeRobot_ShouldThrowException_WhenRobotNull()
        {
            Assert.Throws<InvalidOperationException>(() => robotManager.Charge("pesho"));
        }

        [Test]
        public void ChargeRobot_ShouldWorkProperly()
        {
            int expected = robot.MaximumBattery;
            robotManager.Work("bako", "box", 5);
            robotManager.Charge("bako");

            Assert.AreEqual(expected, robot.Battery);

        }

    }
}
