using System;

using NUnit.Framework;

namespace Tests
{

    public class CarTests
    {
        private Car car;
        private string Make = "Opel";
        private string Model = "Insignia";
        private double FuelConsumption = 7.5;
        private double FuelCapacity = 70;
        private double FuelAmount = 0;

        [SetUp]
        public void Setup()
        {
            car = new Car(Make, Model, FuelConsumption, FuelCapacity);
        }

        [Test]
        public void Constructor_ShouldSetProperties()
        {
            Assert.AreEqual(Make, car.Make);
            Assert.AreEqual(Model, car.Model);
            Assert.AreEqual(FuelConsumption, car.FuelConsumption);
            Assert.AreEqual(FuelCapacity, car.FuelCapacity);
            Assert.AreEqual(FuelAmount, car.FuelAmount);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void PropertyMake_ShouldNotBeNullOrEmpty(string make)
        {
            Assert.Throws<ArgumentException>(() => car = new Car(make, Model, FuelConsumption, FuelCapacity), "Make cannot be null or empty!");
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void PropertyModel_ShouldNotBeNullOrEmpty(string model)
        {
            Assert.Throws<ArgumentException>(() => car = new Car(Make, model, FuelConsumption, FuelCapacity), "Model cannot be null or empty!");
        }

        [Test]
        [TestCase(0)]
        [TestCase(-2.5)]
        public void PropertyFuelConsumption_ShouldNotBeBellowZero(double fuelConsumption)
        {
            Assert.Throws<ArgumentException>(() => car = new Car(Make, Model, fuelConsumption, FuelCapacity),
                "Fuel consumption cannot be zero or negative!");
        }

        [Test]
        [TestCase(0)]
        [TestCase(-2.5)]
        public void PropertyFuelCapacity_ShouldNotBeBellowZero(double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => car = new Car(Make, Model, FuelConsumption, fuelCapacity), 
                "Fuel capacity cannot be zero or negative!");
        }

        [Test]
        [TestCase(0)]
        [TestCase(-2.5)]
        public void MethodRefuel_ShouldNotBeEqualOrBellowZero(double fuelToRefuel)
        {
            Assert.Throws<ArgumentException>(() => car.Refuel(fuelToRefuel),
               "Fuel amount cannot be zero or negative!");
        }

        [Test]
        [TestCase(1)]
        [TestCase(20)]
        public void MethodRefuel_ShouldWorkProperly(double fuelToRefuel)
        {
            car.Refuel(fuelToRefuel);
            Assert.AreEqual(fuelToRefuel, car.FuelAmount);
        }

        [Test]
        [TestCase(90)]
        [TestCase(350)]
        public void MethodRefuel_ShouldEqualizeFuelAmountAndFuelCapacity(double fuelToRefuel)
        {

            car.Refuel(fuelToRefuel);
            Assert.AreEqual(FuelCapacity, car.FuelAmount);
        }

        [Test]
        [TestCase(38.6)]
        [TestCase(45.8)]
        public void DriveMethod_ShouldThrowException_WhenFuelNeededIsMoreThanFuelAmount(double distance)
        {
            Assert.Throws<InvalidOperationException>(() => car.Drive(distance));
        }

        [Test]
        [TestCase(38.6)]
        [TestCase(45.8)]
        public void DriveMethod_ShouldWorkProperly(double distance)
        {
            car.Refuel(10);
            double expected = car.FuelAmount - ((distance / 100) * car.FuelConsumption);
            car.Drive(distance);
            Assert.AreEqual(expected, car.FuelAmount);
        }
    }
}