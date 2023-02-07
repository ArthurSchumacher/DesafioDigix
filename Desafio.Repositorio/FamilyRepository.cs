namespace Desafio.Repository;
using Desafio.Domain;
using Desafio.FakeDB;

public class FamilyRepository : BaseRepo<Family>
{
    public Family Create(Family obj)
    {
        int key = FamilyFakeDB.FamilyList.Last().Id + 1;
        obj.Id = key;

        FamilyFakeDB.FamilyList.Add(obj);

        return obj;
    }

    public Family Delete(Family obj)
    {
        Family original = ReadOne(obj.Id);

        if (original == null)
        {
            return null;
        }
        else
        {
            FamilyFakeDB.FamilyList.Remove(original);
            return original;
        }
    }

    public Family ReadOne(int key)
    {
        return FamilyFakeDB.FamilyList.SingleOrDefault(family => family.Id == key);
    }

    public List<Family> ReadAll()
    {
        return FamilyFakeDB.FamilyList;
    }
}
