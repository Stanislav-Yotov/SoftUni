using NUnit.Framework;
using TheRace;
using System;
using System.Linq;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private RaceEntry drivers;
        private UnitCar car;
        private const string Model = "Opel";
        private const int HorsePower = 160;
        private const double CubicCentimeters = 2000;
        private UnitDriver driver;
        private const string Name = "Pesho";


        [SetUp]
        public void Setup()
        {
            drivers = new RaceEntry();
            car = new UnitCar(Model, HorsePower, CubicCentimeters);
            driver = new UnitDriver(Name, car);
        }

        [Test]
        public void Counter_ShouldWorkProperly()
        {
            drivers.AddDriver(driver);
            Assert.AreEqual(1, drivers.Counter);
        }

        [Test]
        public void AddDriver_ShouldThrowException_WhenDriverNull()
        {
            Assert.Throws<InvalidOperationException>(() => drivers.AddDriver(null));
        }

        [Test]
        public void AddDriver_ShouldThrowException_WhenDriverNameExists()
        {
            drivers.AddDriver(driver);
            UnitDriver driverOne = new UnitDriver("Pesho", car);
            Assert.Throws<InvalidOperationException>(() => drivers.AddDriver(driverOne));
        }

        [Test]
        public void AddDriver_ShouldWorkProperly()
        {
            UnitDriver driverOne = new UnitDriver("Stancho", car);
            drivers.AddDriver(driver);
            drivers.AddDriver(driverOne);
            Assert.AreEqual(2, drivers.Counter);
        }

        [Test]
        public void CalculateAverageHorsePower_ShouldThrowExceptionWhenBelowTwoDrivers()
        {
            drivers.AddDriver(driver);
            Assert.Throws<InvalidOperationException>(() => drivers.CalculateAverageHorsePower());
        }

        [Test]
        public void CalculateAverageHorsePower_ShouldWorkProperly()
        {
            RaceEntry raceEntry = new RaceEntry();
            int n = 5;
            double expected = 0;
            for (int i = 0; i < n; i++)
            {
                int hp = 160 + i;
                raceEntry.AddDriver(new UnitDriver($"Name- {i}", new UnitCar("Model", hp, 2000)));
                expected += hp;
            }
            expected /= n;
            var actual = raceEntry.CalculateAverageHorsePower();
            Assert.AreEqual(expected, actual);
        }
    }
}