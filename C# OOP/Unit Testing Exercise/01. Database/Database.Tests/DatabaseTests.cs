using System;
using System.Linq;
using NUnit.Framework;

namespace Tests
{
    public class DatabaseTests
    {
        private Database database;

        [SetUp]
        public void Setup()
        {
            Database database = new Database();
        }

        [Test]
        public void Constructor_ShouldThrowExceptionIfMoreThan16Elements()
        {
            int[] nums = Enumerable.Range(1, 16).ToArray();
            database = new Database(nums);
            Assert.Throws<InvalidOperationException>(() => database.Add(3), "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void Constructor_ShouldAddElementsWhileTheyAreBelow16()
        {
            int[] nums = Enumerable.Range(1, 15).ToArray();
            database = new Database(nums);
            Assert.AreEqual(15, database.Count);
        }

        [Test]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(8)]
        [TestCase(10)]
        [TestCase(16)]
        public void AddMethod_ShouldAddElementOnTheNextFreeCell(int count)
        {
            database = new Database();
            for (int i = 0; i < count; i++)
            {
                database.Add(i);
            }

            Assert.AreEqual(count, database.Count);
        }

        [Test]
        [TestCase(1, 10, 3, 7)]
        [TestCase(1, 5, 4, 1)]
        public void RemoveMethod_ShouldRemoveElementsIfThereAreAny(int start, int count, int toRemove, int result)
        {
            int[] numbers = Enumerable.Range(start, count).ToArray();
            database = new Database(numbers);
            for (int i = 0; i < toRemove; i++)
            {
                database.Remove();
            }
            Assert.AreEqual(result, database.Count);
        }

        [Test]
        public void RemoveMethod_ShouldThrowExceptionIf0OrBelow()
        {
            database = new Database();
            Assert.Throws<InvalidOperationException>(() => database.Remove());

        }

        [Test]
        public void Fetch_ShouldReturnValidItems()
        {
            database = new Database(1, 2, 3);

            database.Add(4);
            database.Add(5);

            database.Remove();
            database.Remove();
            database.Remove();

            int[] fetched = database.Fetch();
            int[] expected = new int[] { 1, 2 };

            Assert.AreEqual(expected, fetched);
        }


    }
}