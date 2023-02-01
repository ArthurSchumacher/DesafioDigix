namespace Desafio.Servico;

using System.Collections.Generic;
using Desafio.Dominio;
using Desafio.Repositorio;

public class FamiliaServico : BaseServ<Familia>
{
    private FamiliaRepositorio repo;

    public FamiliaServico() : base()
    {
        this.repo = new FamiliaRepositorio();
    }

    public override Familia Adicionar(Familia obj)
    {
        return repo.Criar(obj);
    }

    public override Familia Remover(Familia obj)
    {
        return repo.Deletar(obj);
    }

    public override List<Familia> Procurar()
    {
        return repo.LerTodos();
    }

    public override Familia ProcurarUm(int key)
    {
        return repo.LerUm(key);
    }

}
