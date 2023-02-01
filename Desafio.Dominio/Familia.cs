using System.Collections.Generic;
namespace Desafio.Dominio;

public class Familia
{
    public int Id { get; set; }
    public double RendaTotal { get; set; }
    public int Pontuacao { get; set; }
    public List<Pessoa> MembrosFamilia { get; set; }
    public int QtdPessoasDependentes { get; set; }

    public Familia()
    {
        MembrosFamilia = new List<Pessoa>();
    }

    public Familia(double rendaTotal)
    {
        RendaTotal = rendaTotal;
        Pontuacao = 0;
        MembrosFamilia = new List<Pessoa>();
    }

    public void AdicionarMembro(Pessoa novoMembro)
    {
        MembrosFamilia.Add(novoMembro);
    }

    public void RemoverMembro(Pessoa membroFamilia)
    {
        MembrosFamilia.Remove(membroFamilia);
    }

    public void CalcularPontuacao()
    {
        if (Pontuacao == 0)
        {
            CalcularDependentes(MembrosFamilia);

            if (RendaTotal <= 900)
            {
                Pontuacao += 5;
            }

            if (RendaTotal >= 901 && RendaTotal <= 1500)
            {
                Pontuacao += 3;
            }

            if (QtdPessoasDependentes >= 3)
            {
                Pontuacao += 3;
            }

            if (QtdPessoasDependentes > 0 && QtdPessoasDependentes <= 2)
            {
                Pontuacao += 2;
            }
        }
    }

    private void CalcularDependentes(List<Pessoa> membrosFamilia)
    {
        foreach (Pessoa dependente in membrosFamilia)
        {
            if (dependente.Idade <= 18)
            {
                QtdPessoasDependentes += 1;
            }
        }
    }
}