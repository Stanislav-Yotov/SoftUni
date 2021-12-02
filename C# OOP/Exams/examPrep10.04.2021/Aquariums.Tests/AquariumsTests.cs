namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;

    public class AquariumsTests
    {
        private Aquarium aquarium;
        private const string Name = "name";
        private const int Capacity = 1;

        [SetUp]
        public void SetUp()
        {
            aquarium = new Aquarium(Name, Capacity);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void ConstructorName_ShouldThrowException_WhenNull(string name)
        {
            Assert.Throws<ArgumentNullException>(() => aquarium = new Aquarium(name, Capacity));
        }

        [Test]
        [TestCase("pesho")]
        [TestCase("gogi")]
        public void ConstructorName_ShouldWorkProperly(string name)
        {
            aquarium = new Aquarium(name, Capacity);
            string expected = name;
            Assert.AreEqual(expected, name);
        }

        [Test]
        [TestCase(1)]
        public void ConstructorCapacity_ShouldWorkProperly(int capacity)
        {
            aquarium = new Aquarium(Name, capacity);
            Assert.AreEqual(capacity, aquarium.Capacity);
        }

        [Test]
        [TestCase(-1)]
        public void ConstructorCapacity_ShouldThrowException_WhenCapacityWrong(int capacity)
        {

            Assert.Throws<ArgumentException>(() => aquarium = new Aquarium(Name, capacity));
        }

        [Test]
        public void AddMethod_ShouldThrowException_WhenCapacityWrong()
        {
            aquarium = new Aquarium(Name, 2);
            aquarium.Add(new Fish("gogi"));
            aquarium.Add(new Fish("gosho"));
            Assert.Throws<InvalidOperationException>(() => aquarium.Add(new Fish("pesho")));

        }

        [Test]
        public void AddMethod_ShouldWorkProperly()
        {
            aquarium = new Aquarium(Name, 10);
            aquarium.Add(new Fish("gogi"));
            aquarium.Add(new Fish("pesho"));
            aquarium.Add(new Fish("zozi"));

            int expected = 3;
            Assert.AreEqual(expected, aquarium.Count);
        }

        [Test]
        [TestCase(null)]
        public void RemoveMethod_ShouldThrowException_WhenNameIsNull(string name)
        {
            Assert.Throws<InvalidOperationException>(() => aquarium.RemoveFish(name));
        }

        [Test]
        public void RemoveMethod_ShouldWorkProperly()
        {
            aquarium = new Aquarium(Name, 3);
            Fish first = new Fish("pesho");
            Fish second = new Fish("gogi");
            aquarium.Add(first);
            aquarium.Add(second);
            aquarium.RemoveFish("pesho");
            int expected = 1;
            Assert.AreEqual(expected, aquarium.Count);

        }

    }
}
