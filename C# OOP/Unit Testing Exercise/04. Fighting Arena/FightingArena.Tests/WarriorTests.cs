using System;

using FightingArena;
using NUnit.Framework;

namespace FightingArena
{
    public class WarriorTests
    {
        private Warrior warrior;
        private string Name = "Geralt";
        private int Damage = 40;
        private int HP = 100; 

        [SetUp]
        public void Setup()
        {
             warrior = new Warrior(Name, Damage, HP);
        }

        [Test]
        [TestCase("Stancho", 50, 80)]
        public void Constructor_ShouldSetEverythingIfDataIsCorrect(string name, int damage, int hp)
        {
            warrior = new Warrior(name, damage, hp);
            Assert.AreEqual(name, warrior.Name);
            Assert.AreEqual(damage, warrior.Damage);
            Assert.AreEqual(hp, warrior.HP);
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        [TestCase(" ")]
        public void PropertyName_ShouldThrowException_WhenNullOrEmptyOrWhiteSPace(string name)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, Damage, HP), "Name should not be empty or whitespace!");
        }

        [Test]
        [TestCase(0)]
        [TestCase(-5)]
        [TestCase(-20)]
        public void PropertyDamage_ShouldThrowException_WhenZeroOrNegative(int damage)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(Name, damage, HP), "Damage value should be positive!");
        }

        [Test]
        [TestCase(-5)]
        [TestCase(-20)]
        public void PropertyHP_ShouldThrowException_WhenNegative(int hp)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(Name, Damage, hp), "HP should not be negative!");
        }
       
        [Test]
        [TestCase("Stancho", 40, 30, "Bace", 40, 40)]
        public void AttackMethod_ShouldThrowException_WhenHPEqualOrBelow30(string name, int damage, int hp, 
            string enemyName, int enemyDamage, int enemyHp)
        {
            Warrior myWarrior = new Warrior(name, damage, hp);
            Warrior enemyWarrior = new Warrior(enemyName, enemyDamage, enemyHp);
            Assert.Throws<InvalidOperationException>(() => myWarrior.Attack(enemyWarrior),
                "Your HP is too low in order to attack other warriors!");
        }

        [Test]
        [TestCase("Stancho", 40, 40, "Bace", 40, 30)]
        public void AttackMethod_ShouldThrowException_WhenAttackingWeakEnemy(string name, int damage, int hp,
           string enemyName, int enemyDamage, int enemyHp)
        {
            Warrior myWarrior = new Warrior(name, damage, hp);
            Warrior enemyWarrior = new Warrior(enemyName, enemyDamage, enemyHp);
            Assert.Throws<InvalidOperationException>(() => myWarrior.Attack(enemyWarrior),
               "Enemy HP must be greater than 30 in order to attack him!");
        }


        [Test]
        [TestCase("Stancho", 40, 40, "Bace", 80, 40)]
        public void AttackMethod_ShouldThrowException_WhenAttackingTooStrongEnemy(string name, int damage, int hp,
           string enemyName, int enemyDamage, int enemyHp)
        {
            Warrior myWarrior = new Warrior(name, damage, hp);
            Warrior enemyWarrior = new Warrior(enemyName, enemyDamage, enemyHp);
            Assert.Throws<InvalidOperationException>(() => myWarrior.Attack(enemyWarrior),
              "You are trying to attack too strong enemy");
        }

        [Test]
        [TestCase("Stancho", 40, 80, "Bace", 40, 40)]
        public void AttackMethod_ShouldWorkProperly(string name, int damage, int hp,
         string enemyName, int enemyDamage, int enemyHp)
        {
            Warrior myWarrior = new Warrior(name, damage, hp);
            Warrior enemyWarrior = new Warrior(enemyName, enemyDamage, enemyHp);
            int expected = 40;
            myWarrior.Attack(enemyWarrior);
            Assert.AreEqual(expected, myWarrior.HP);
        }

        [Test]
        [TestCase("Stancho", 50, 80, "Bace", 40, 40)]
        public void AttackMethodEnemyHero_ShouldDie_WhenOurAttackIsMoreThanHisHp(string name, int damage, int hp,
         string enemyName, int enemyDamage, int enemyHp)
        {
            Warrior myWarrior = new Warrior(name, damage, hp);
            Warrior enemyWarrior = new Warrior(enemyName, enemyDamage, enemyHp);
            int expected = 0;
            myWarrior.Attack(enemyWarrior);
            Assert.AreEqual(expected, enemyWarrior.HP);
        }

        [Test]
        [TestCase("Stancho", 30, 80, "Bace", 40, 40)]
        public void AttackMethodEnemyHero_ShouldReduceHP_WhenAttacked(string name, int damage, int hp,
        string enemyName, int enemyDamage, int enemyHp)
        {
            Warrior myWarrior = new Warrior(name, damage, hp);
            Warrior enemyWarrior = new Warrior(enemyName, enemyDamage, enemyHp);
            int expected = 10;
            myWarrior.Attack(enemyWarrior);
            Assert.AreEqual(expected, enemyWarrior.HP);
        }

    }
}