using System;
using System.Linq;
using FightingArena;
using NUnit.Framework;

namespace FightingArena
{
    public class ArenaTests
    {
        private Arena arena;

        [SetUp]
        public void Setup()
        {  
        }

        [Test]
        public void Constructor_ShouldSetValues()
        {
            arena = new Arena();
            Assert.IsNotNull(arena.Warriors);
        }

        [Test]
        public void Enroll_ShouldWorkProperly()
        {
            arena = new Arena();
            Warrior warrior = new Warrior("Stancho", 40, 40);
            Warrior warriorTwo = new Warrior("Pesho", 50, 60);
            Warrior warriorThree = new Warrior("Marto", 46, 75);

            arena.Enroll(warrior);
            arena.Enroll(warriorTwo);
            arena.Enroll(warriorThree);

            bool warriorExists = arena.Warriors.Contains(warrior);
            bool warriorTwoExists = arena.Warriors.Contains(warriorTwo);
            bool warriorThreeExists = arena.Warriors.Contains(warriorThree);


            Assert.AreEqual(3, arena.Count);
            Assert.IsTrue(warriorExists);
            Assert.IsTrue(warriorTwoExists);
            Assert.IsTrue(warriorThreeExists);

        }

        [Test]
        public void Enroll_ShouldThrowException_WhenWarriorAlreadyExists()
        {
            arena = new Arena();
            Warrior warrior = new Warrior("Stancho", 40, 40);
            arena.Enroll(warrior);
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior));
        }

        [Test]
        public void FightMethod_ShouldThrowExceptionForInvalidPlayers()
        {
            arena = new Arena();
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Stancho", "Pesho"));
        }

        [Test]
        public void FightMethod_ShouldThrowExceptionForInvalidAttacker()
        {
            arena = new Arena();
            Warrior defender = new Warrior("Pesho", 50, 50);
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Stancho", "Pesho"));
        }

        [Test]
        public void FightMethod_ShouldThrowExceptionForInvalidDefender()
        {
            arena = new Arena();
            Warrior attacker = new Warrior("Stancho", 50, 50);
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Stancho", "Pesho"));
        }

        [Test]
        public void FightMethod_ShouldWorkProperly()
        {
            arena = new Arena();
            Warrior attacker = new Warrior("Stancho", 100, 50);
            Warrior defender = new Warrior("Pesho", 50, 100);
            arena.Enroll(attacker);
            arena.Enroll(defender);
            arena.Fight("Stancho", "Pesho");
            int expected = 0;
            Warrior attackerWarrior = arena.Warriors.FirstOrDefault(w => w.Name == "Stancho");
            Warrior defenderWarrior = arena.Warriors.FirstOrDefault(w => w.Name == "Pesho");

            Assert.AreEqual(expected, attackerWarrior.HP);
            Assert.AreEqual(expected, defenderWarrior.HP);
        }
    }
}
