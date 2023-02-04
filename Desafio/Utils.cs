using Desafio.Consumo;
namespace Desafio;

public static class Utils
{
    private static FamilyOp opFamily = new FamilyOp();

    public static void FirstScreen()
    {
        Console.Clear();
        Console.WriteLine("Welcome, choose an option: ");
        Console.WriteLine("1) Add 10 families");
        Console.WriteLine("2) List families");
        Console.WriteLine("3) Exit");
        Console.Write("\r\nSelect an option: ");

        switch (int.Parse(Console.ReadLine()))
        {
            case 1:
                opFamily.Add10();
                FirstScreen();
                break;
            
            case 2:
                opFamily.ListFamilies();
                FirstScreen();
                break;
            
            case 3:
                Console.Clear();
                Console.WriteLine("Ending program.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                break;
            default:
                FirstScreen();
                break;

        }
    }
}
