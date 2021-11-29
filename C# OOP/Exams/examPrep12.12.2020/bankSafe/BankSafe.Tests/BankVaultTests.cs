using NUnit.Framework;
using System;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private BankVault vault;
        private Item item;

        [SetUp]
        public void Setup()
        {
            vault = new BankVault();
            item = new Item("az", "5");
        }

        [Test]
        public void AddItem_ShouldThrowException_WhenCellDoesnNotExist()
        {
            Assert.Throws<ArgumentException>(() => vault.AddItem("neshto", item), "Cell doesn't exists!");
        }

        [Test]
        public void AddItem_ShouldThrowException_WhenCellIsTaken()
        {
            vault.AddItem("A3", item);
            Assert.Throws<ArgumentException>(() => vault.AddItem("A3", new Item("zoki", "pet")), "Cell is already taken!");
        }

        [Test]
        public void AddItem_ShouldThrowException_WhenItemsAlreadyExists()
        {
            vault.AddItem("A3", item);
            Assert.Throws<InvalidOperationException>(() => vault.AddItem("A2", item), "Item is already in cell!");
        }

        [Test]
        public void AddItem_ShouldWorkProperly()
        {
            string result = vault.AddItem("A3", item);
            Assert.AreEqual(result, $"Item:{item.ItemId} saved successfully!");
        }

        [Test]
        public void RemoveItem_ShouldThrowException_WhenCellDoesnNotExist()
        {
            Assert.Throws<ArgumentException>(() => vault.RemoveItem("neshto", item), "Cell doesn't exists!");
        }

        [Test]
        public void RemoveItem_ShouldThrowException_WhenItemDoesNotExist()
        {
            Assert.Throws<ArgumentException>(() => vault.RemoveItem("B4", item), "Item in that cell doesn't exists!");
        }

        [Test]
        public void RemoveItem_ShouldWorkProperly()
        {
            vault.AddItem("A3", item);
            string expected = vault.RemoveItem("A3", item);
            Assert.AreEqual(expected, $"Remove item:{item.ItemId} successfully!");
        }

        [Test]
        public void RemoveItem_ShouldReturnCellNull()
        {
            vault.AddItem("A3", item);
            vault.RemoveItem("A3", item);
            Assert.AreEqual(null, vault.VaultCells["A3"]);
        }
    }
}