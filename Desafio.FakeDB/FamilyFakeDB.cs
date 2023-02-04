using Desafio.Domain;

namespace Desafio.FakeDB
{
    public static class FamilyFakeDB
    {
        private static readonly Lazy<List<Family>> _familyList = new Lazy<List<Family>>(Fill);

        public static List<Family> FamilyList => _familyList.Value;

        private static List<Family> Fill()
        {
            List<Family> familyList = new List<Family>();
            Family firstFamily = new Family(3000);
            Person dependentPerson = new Person(19);
            firstFamily.AddMember(dependentPerson);
            firstFamily.CalculateScore();

            familyList.Add(firstFamily);

            return familyList;
        }
    }
}
