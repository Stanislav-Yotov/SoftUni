using System;

using NUnit.Framework;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase database;
        private int capacity = 16;

        [SetUp]
        public void SetUp()
        {
            database = new ExtendedDatabase(
                new Person(1, "Asen"),
                new Person(2, "Yoana"),
                new Person(3, "Marto"),
                new Person(4, "Rado"),
                new Person(5, "Venko"),
                new Person(6, "Gosho"),
                new Person(7, "Bratcheda"),
                new Person(8, "Ana"),
                new Person(9, "Mihaela"),
                new Person(10, "Vlado"),
                new Person(11, "Bako"),
                new Person(12, "Iana"),
                new Person(13, "Grue"),
                new Person(14, "Marti"),
                new Person(15, "Magi")); 
        }

        [Test]
        public void Constructor_ShouldThrowException_WhenAddingMoreThanMaxCapacity()
        {
            database.Add(new Person(16, "Nekoi"));
            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(17, "Oshte nekoi")));
        }

        [Test]
        public void Count_ShouldReturnDatabaseCount()
        {
            int expected = 15;
            Assert.AreEqual(expected, database.Count);
        }

        [Test]
        public void AddMethod_ShouldThrowExceptionIfPersonAlreadyExists()
        {
            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(16, "Bako")),"There is already user with this username!");
        }

        [Test]
        public void AddMethod_ShouldThrowExceptionIfPersonIdAlreadyExists()
        {
            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(10, "Gogi")), "There is already user with this Id!");
        }

        [Test]
        public void AddMethod_ShouldWorkProperly()
        {
            database.Add(new Person(16, "Gogicha"));
            int expected = 16;
            Assert.AreEqual(expected, database.Count);
        }

        [Test]
        public void RemoveMethod_ShouldWorkProperly()
        {
            int expected = 14;
            database.Remove();
            Assert.AreEqual(expected, database.Count);
        }

        [Test]
        public void RemoveMethod_ShouldThrowException_WhenCollectionIsEmpty()
        {
            database = new ExtendedDatabase();
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void AddRangeMethod_ShouldThrowException_WhenAddedMoreThanItsCapacity()
        {
            Person[] people = new Person[] {
                new Person(1, "Asen"),
                new Person(2, "Yoana"),
                new Person(3, "Marto"),
                new Person(4, "Rado"),
                new Person(5, "Venko"),
                new Person(6, "Gosho"),
                new Person(7, "Bratcheda"),
                new Person(8, "Ana"),
                new Person(9, "Mihaela"),
                new Person(10, "Vlado"),
                new Person(11, "Bako"),
                new Person(12, "Iana"),
                new Person(13, "Grue"),
                new Person(14, "Marti"),
                new Person(15, "Magi"),
                new Person(16, "Stefcho"),
                new Person(17, "Ilya")
        };
            Assert.Throws<ArgumentException>(() => new ExtendedDatabase(people), "Provided data length should be in range [0..16]!");
    }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void FindByUsernameMethod_ShouldThrowException_WhenEmptyOrNull(string name)
        {
            Assert.Throws<ArgumentNullException>(() => database.FindByUsername(name), "Username parameter is null!");
        }

        [Test]
        [TestCase("Shabanq")]
        [TestCase("Kolio Piqnicata")]
        [TestCase("Lepa Brena")]
        [TestCase("Zoki")]
        public void FindByUsernameMethod_ShouldThrowException_WhenNameDoesntExist(string name)
        {
            Assert.Throws<InvalidOperationException>(() => database.FindByUsername(name), "No user is present by this username!");
        }

        [Test]
        [TestCase("Asen")]
        public void FindByUsernameMethod_ShouldWorkProperly(string name)
        {
            Person expected = new Person(1, "Asen");
            Person result = database.FindByUsername(name);
            Assert.AreEqual(expected.UserName, result.UserName);
            Assert.AreEqual(expected.Id, result.Id);
        }

        [Test]
        [TestCase(-2)]
        [TestCase(-10)]
        public void FindByIdMethod_ShouldThrowException_WhenIdNegative(long id)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(id), "Id should be a positive number!");
        }

        [Test]
        [TestCase(19)]
        [TestCase(29)]
        public void FindByIdMethod_ShouldThrowException_WhenIdWrong(long id)
        {
            Assert.Throws<InvalidOperationException>(() => database.FindById(id), "No user is present by this ID!");
        }

        [Test]
        [TestCase(1)]
        public void FindByIdMethod_ShouldWorkProperly(long id)
        {
            Person expected = new Person(1, "Asen");
            Person result = database.FindById(id);
            Assert.AreEqual(expected.UserName, result.UserName);
            Assert.AreEqual(expected.Id, result.Id);
        }
    }
}