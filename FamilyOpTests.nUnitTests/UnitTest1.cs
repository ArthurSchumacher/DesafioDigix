namespace FamilyOpTests.nUnitTests;

public class Tests
{
    private FamilyOp _familyOp;

    [SetUp]
    public void Setup()
    {
        _familyOp = new FamilyOp();
    }

    [Test]
    public void Add10_ShouldAdd10FamiliesWithCorrectRandomValues()
    {
        // Act
        _familyOp.Add10();

        // Assert
        List<Family> families = FamilyService.Browse().ToList();
        Assert.AreEqual(11, families.Count());

        foreach (Family family in families)
        {
            // Check if the total income is within the expected range
            Assert.That(family.TotalIncome, Is.InRange(0, 3000.00));

            // Check if each person's age is within the expected range
            Assert.That(family.FamilyMembers.All(m => m.Age >= 0 && m.Age <= 37), Is.True);
        }
    }
}