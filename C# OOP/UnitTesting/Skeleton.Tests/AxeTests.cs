using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    private Axe axe;
    private Dummy dummy;

    [SetUp]
    public void SetUp()
    {
        axe = new Axe(1, 1);
        dummy = new Dummy(5, 5);

    }
    [Test]
    public void AxeLoosesDurbailityAfterAttack()
    {
        axe.Attack(dummy);
        Assert.That(axe.DurabilityPoints, Is.EqualTo(0), "Axe durabilty doesn't change after attack.");
    }

    [Test]
    public void AxeAttackingWithNoDurabilityShould_ThrowException()
    {
        
        axe.Attack(dummy);
        Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy), "Axe is broken.");

    }
}






