namespace Desafio.Service;

using System.Collections.Generic;
using Desafio.Domain;
using Desafio.Repository;

public static class FamilyService
{
    private static readonly FamilyRepository _repository = new FamilyRepository();

    public static Family Add(Family obj)
    {
        return _repository.Create(obj);
    }

    public static Family Delete(Family obj)
    {
        return _repository.Delete(obj);
    }

    public static List<Family> Browse()
    {
        return _repository.ReadAll();
    }

    public static Family Read(int key)
    {
        return _repository.ReadOne(key);
    }
}
