using Desafio.Consumo;
namespace Desafio;

public static class Utils
{
    private static FamiliaOp opFamilia = new FamiliaOp();

    public static void PrimeiraTela()
    {
        Console.Clear();
        Console.WriteLine("Seja bem vindo(a), escolha uma opção: ");
        Console.WriteLine("1) Adicionar 10 familias");
        Console.WriteLine("2) Listar familias");
        Console.WriteLine("3) Sair");
        Console.Write("\r\nSelecione uma opção: ");

        switch (int.Parse(Console.ReadLine()))
        {
            case 1:
                opFamilia.Adicionar10();
                PrimeiraTela();
                break;
            
            case 2:
                opFamilia.ListarFamilias();
                PrimeiraTela();
                break;
            
            case 3:
                Console.Clear();
                Console.WriteLine("Encerrando programa.");
                Console.WriteLine("Pressione qualquer tecla para continuar.");
                Console.ReadKey();
                break;
            default:
                PrimeiraTela();
                break;

        }
    }
}
