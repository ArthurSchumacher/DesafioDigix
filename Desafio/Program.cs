using System;
using Desafio.Dominio;

namespace Desafio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Desafio.Utils.PrimeiraTela();
            }
            catch (System.Exception e)
            {
                Console.WriteLine($"An error occured: {e.Message}");
                Console.ReadKey();
            }
        }
    }
}