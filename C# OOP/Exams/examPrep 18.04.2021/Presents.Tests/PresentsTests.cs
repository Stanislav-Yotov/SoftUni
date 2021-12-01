namespace Presents.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class PresentsTests
    {
        private Bag bag;

        [SetUp]
        public void SetUp()
        {
            bag = new Bag();
        }

        [Test]
        public void Constructor_ShouldWorkProperly()
        {
            bag = new Bag();
            Assert.IsNotNull(bag);
        }

        [Test]
        [TestCase(null)]
        public void Create_ShouldThrowException_WhenPresentIsNull(Present present)
        {
            bag = new Bag();
            Assert.Throws<ArgumentNullException>(() => bag.Create(present));       
        }

        
        [Test]
        public void Create_ShouldThrowException_WhenPresentAlreadyExists()
        {
            bag = new Bag();
            Present present = new Present("present", 3.3);
            bag.Create(present);
            Assert.Throws<InvalidOperationException>(() => bag.Create(present));
            
        }

        [Test]
        public void Create_ShouldWorkProperly()
        {
            bag = new Bag();
            int expected = 1;
            Present present = new Present("name", 2.5);
            bag.Create(present);
            int count = bag.GetPresents().Count;
            Assert.AreEqual(expected, count);
        }

        [Test]
        public void Remove_ShouldWorkProperly()
        {
            bag = new Bag();
            Present first = new Present("firstName", 4.1);
            Present second = new Present("secondName", 3.4);
            bag.Create(first);
            bag.Create(second);
            bag.Remove(second);
            int expexted = 1;
            int count = bag.GetPresents().Count;
            Assert.AreEqual(expexted, count);
        }

        [Test]
        public void TestPresentWithLeastMagic()
        {
            Present first = new Present("first", 2);
            Present second = new Present("second", 3);
            bag.Create(first);
            bag.Create(second);
            bag.GetPresentWithLeastMagic();
            var expected = first;
            Assert.AreEqual(expected, first);
        }

        
        [Test]
        [TestCase("first", 2.5)]
        public void GetPresent_ShouldWorkProperly(string name, double magic)
        {
            Present first = new Present(name, magic);
            bag.Create(first);
            bag.GetPresent(name);
            string expected = "first";
            Assert.AreEqual(expected, first.Name);
        }
    }
}
