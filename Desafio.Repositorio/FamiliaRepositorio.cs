namespace Desafio.Repositorio;

using System.Collections.Generic;
using Desafio.Dominio;
using Desafio.FakeDB;

public class FamiliaRepositorio : BaseRepo<Familia>
{
    public override Familia Criar(Familia obj)
    {
        int key = FamiliaFakeDB.ListaFamilias.Last().Id + 1;
        obj.Id = key;

        FamiliaFakeDB.ListaFamilias.Add(obj);

        return obj;
    }

    public override Familia Deletar(Familia obj)
    {
        Familia original = this.LerUm(obj.Id);

        if (original == null)
        {
            return null;
        }
        else
        {
            FamiliaFakeDB.ListaFamilias.Remove(original);
            return original;
        }
    }

    public override Familia LerUm(int key)
    {
        return FamiliaFakeDB.ListaFamilias.SingleOrDefault(familia => familia.Id == key);
    }

    public override List<Familia> LerTodos()
    {
        return FamiliaFakeDB.ListaFamilias;
    }
}
