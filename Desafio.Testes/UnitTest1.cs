namespace Desafio.Consumo.Tests
{
    [TestFixture]
    public class FamilyOpTests
    {
        private FamilyOp _familyOp;

        [SetUp]
        public void SetUp()
        {
            _familyOp = new FamilyOp();
        }

        [Test]
        public void Add10_ShouldAdd10FamiliesWithCorrectRandomValues()
        {
            // Act
            _familyOp.Add10();

            // Assert
            var families = FamilyService.Browse().ToList();
            Assert.AreEqual(11, families.Count());

            foreach (var family in families)
            {
                // Check if the total income is within the expected range
                Assert.That(family.TotalIncome, Is.InRange(0, 3000));

                // Check if each person's age is within the expected range
                Assert.That(family.FamilyMembers.All(m => m.Age >= 0 && m.Age <= 37), Is.True);
            }
        }
    }
}
