namespace Desafio.Servico;

public abstract class BaseServ<TClasse> where TClasse : class
{
    public abstract TClasse Adicionar(TClasse obj);
    public abstract TClasse Remover(TClasse obj);
    public abstract List<TClasse> Procurar();
    public abstract TClasse ProcurarUm(int key);
}
