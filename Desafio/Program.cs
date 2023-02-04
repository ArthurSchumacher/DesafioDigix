using System;
using Desafio.Domain;

namespace Desafio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Desafio.Utils.FirstScreen();
            }
            catch (System.Exception e)
            {
                Console.WriteLine($"An error occured: {e.Message}");
                Console.ReadKey();
            }
        }
    }
}