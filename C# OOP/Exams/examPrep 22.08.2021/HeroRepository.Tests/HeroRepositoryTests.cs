using System;
using NUnit.Framework;

public class HeroRepositoryTests
{
    private HeroRepository heroes;

    [SetUp]
    public void SetUp()
    {
        heroes = new HeroRepository();
    }

    [Test]
    public void CreateHero_ShouldThrowException_WhenNull()
    {
        Assert.Throws<ArgumentNullException>(() => heroes.Create(null));
    }

    [Test]
    public void CreateHero_ShouldThrowException_WhenNameExists()
    {
        heroes.Create(new Hero("Pesho", 5));
        Assert.Throws<InvalidOperationException>(() => heroes.Create(new Hero("Pesho", 6)));
    }

    [Test]
    public void CreateHero_ShouldWorkProperly()
    {
        heroes.Create(new Hero("Pesho", 5));
        heroes.Create(new Hero("Stancho", 5));
        Assert.AreEqual(2, heroes.Heroes.Count);
    }

    [Test]
    [TestCase(null)]
    [TestCase(" ")]
    public void RemoveHero_ShouldThrowException_WhenNameDoesNotExist(string name)
    {
        Assert.Throws<ArgumentNullException>(() => heroes.Remove(name));
    }

    [Test]
    public void RemoveHero_ShouldWorkProperly()
    {
        heroes.Create(new Hero("Pesho", 5));
        heroes.Create(new Hero("Stancho", 5));
        heroes.Remove("Stancho");
        Assert.AreEqual(1, heroes.Heroes.Count);
    }

    [Test]
    public void GetHeroWithHighestLevel_ShouldWorkProperly()
    {
        heroes.Create(new Hero("Pesho", 5));
        heroes.Create(new Hero("Stancho", 15));
        var expectedName = "Stancho";
        var expectedLvl = 15;
        var expectedHero = heroes.GetHeroWithHighestLevel();
        Assert.AreEqual(expectedName, expectedHero.Name);
        Assert.AreEqual(expectedLvl, expectedHero.Level);
    }

    [Test]
    public void GetHero_ShouldWorkProperly()
    {
        heroes.Create(new Hero("Stancho", 15));
        var expectedName = "Stancho";
        var expectedLvl = 15;
        var expectedHero = heroes.GetHero("Stancho");
        Assert.AreEqual(expectedName, expectedHero.Name);
        Assert.AreEqual(expectedLvl, expectedHero.Level);
    }



}