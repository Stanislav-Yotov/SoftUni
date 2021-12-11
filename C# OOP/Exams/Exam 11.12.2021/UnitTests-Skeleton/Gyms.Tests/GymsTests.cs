using NUnit.Framework;
using System;

namespace Gyms.Tests
{
    public class GymsTests
    {
        private Gym gym;
        private const string name = "name";
        private const int size = 20;
        Athlete athlete;
        private const string athleteName = "Pesho";

        [SetUp]
        public void SetUp()
        {
            gym = new Gym(name, size);
            athlete = new Athlete(athleteName);
        }

        [Test]
        public void Constructor_ShouldWorkProperly()
        {
            Assert.AreEqual(name, gym.Name);
            Assert.AreEqual(size, gym.Capacity);
        }

        [Test]
        public void Constructor_ShouldThrowExceptions_WhenNameIsWrong()
        {
            Assert.Throws<ArgumentNullException>(() => gym = new Gym(null, 5));
            Assert.Throws<ArgumentNullException>(() => gym = new Gym("", 5));
        }

        [Test]
        public void Constructor_ShouldThrowExceptions_WhenSizeIsWrong()
        {
            Assert.Throws<ArgumentException>(() => gym = new Gym(name, -2));
        }

        [Test]
        public void AddAthlete_ShouldThrowException_WhenGymFull()
        {
            gym = new Gym(name, 1);
            gym.AddAthlete(athlete);
            Assert.Throws<InvalidOperationException>(() => gym.AddAthlete(new Athlete("Gosho")));
        }

        [Test]
        public void AddAthlete_ShouldWorkProperly()
        {
            gym.AddAthlete(athlete);
            Assert.AreEqual(1, gym.Count);
        }

        [Test]
        public void RemoveAthlete_ShouldThrowExceptionWhenNameNull()
        {
            gym.AddAthlete(athlete);
            Assert.Throws<InvalidOperationException>(() => gym.RemoveAthlete("Gosho"));
        }

        [Test]
        public void RemoveAthlete_ShouldWorkProperly()
        {
            gym.AddAthlete(athlete);
            gym.AddAthlete(new Athlete("Gosho"));
            gym.RemoveAthlete("Gosho");
            Assert.AreEqual(1, gym.Count);
            Assert.Throws<InvalidOperationException>(() => gym.RemoveAthlete("Gosho"));
        }

        [Test]
        public void InjureAthlete_ShouldThrowException_WhenAthleteNameNull()
        {
            gym.AddAthlete(athlete);
            Assert.Throws<InvalidOperationException>(() => gym.InjureAthlete("Gosho"));
        }

        [Test]
        public void InjureAthlete_ShouldWorkProperly()
        {
            gym.AddAthlete(athlete);
            gym.InjureAthlete("Pesho");
            Assert.AreEqual(gym.InjureAthlete("Pesho"), athlete);
        }

        [Test]
        public void Report_ShouldWorkProperly()
        {
            gym.AddAthlete(athlete);
            var expected = "Active athletes at name: Pesho";
            Assert.AreEqual(expected, gym.Report());
        }

        

       

       
    }
}
