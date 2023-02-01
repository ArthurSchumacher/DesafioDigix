using Desafio.Dominio;
using Desafio.Servico;
using System.Collections.Generic;

namespace Desafio.Consumo;

public class FamiliaOp
{
    private FamiliaServico servico;

    public FamiliaOp()
    {
        servico = new FamiliaServico();
    }

    public void Adicionar10()
    {
        Random rand = new Random();

        for (int i = 0; i < 10; i++)
        {
            Familia familia = new Familia();
            familia.RendaTotal = rand.NextDouble() * 3000;

            for (int j = 0; j < 5; j++)
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Idade = rand.Next(0, 37);
                familia.AdicionarMembro(pessoa);
            }

            familia.CalcularPontuacao();
            servico.Adicionar(familia);
        }

        Console.Clear();
        Console.WriteLine("10 Familias, adicionadas com sucesso!");
        Console.ReadKey();
    }

    public void ListarFamilias()
    {
        List<Familia> familias = servico.Procurar().OrderByDescending(obj => obj.Pontuacao).ToList();
        Console.WriteLine("\nListar todas as familias: ");
        foreach (Familia familia in familias)
        {
            Console.WriteLine($"Familia: {familia.Id}, Membros dependentes: {familia.QtdPessoasDependentes}, Renda: R$ {familia.RendaTotal.ToString("F2")}, Pontuação: {familia.Pontuacao}");
        }

        Console.ReadKey();
    }
}
