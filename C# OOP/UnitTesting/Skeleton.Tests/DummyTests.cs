using NUnit.Framework;
using System;

[TestFixture]
public class DummyTests
{
    private Axe axe;
    private Dummy dummy;
    private const int axeAtt = 10;
    private const int axeDurability = 10;
    private const int dummyHpp = 10;
    private const int dummyExp = 10;

    [SetUp]
    public void SetUp()
    {
        axe = new Axe(axeAtt, axeDurability);
        dummy = new Dummy(dummyHpp, dummyExp);
    }

    [Test]
    public void DummyLossesHealth_WhenAttacked()
    {
        dummy.TakeAttack(axeAtt);
        Assert.That(dummy.Health, Is.EqualTo(0));
    }

    [Test]
    public void DeadDummyThrowsException_WhenAttacked()
    {
        dummy.TakeAttack(axeAtt);
        Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(axeAtt), "Dummy is dead.");
    }

    [Test]
    public void DeadDummy_ShouldGiveExperience()
    {
        dummy.TakeAttack(axeAtt);
        int experience = dummy.GiveExperience();
        Assert.AreEqual(dummyExp, experience);
    }

    [Test]
    public void AliveDummy_ShoudNotGiveExperience()
    {
        Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
    }
}
