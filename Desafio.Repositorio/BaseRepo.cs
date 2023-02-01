namespace Desafio.Repositorio;

using Desafio.Dominio;
using Desafio.FakeDB;

public abstract class BaseRepo<TClasse> where TClasse : class
{
    public abstract TClasse Criar(TClasse obj);

    public abstract TClasse Deletar(TClasse obj);

    public abstract TClasse LerUm(int key);

    public abstract List<TClasse> LerTodos();
}
