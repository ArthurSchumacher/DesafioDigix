using Desafio.Domain;
using Desafio.Service;
using System.Collections.Generic;

namespace Desafio.Consumo;

public class FamilyOp
{
    public void Add10()
    {
        Random rand = new Random();

        for (int i = 0; i < 10; i++)
        {
            Family family = new Family();
            family.TotalIncome = rand.NextDouble() * 3000;

            for (int j = 0; j < 5; j++)
            {
                Person person = new Person();
                person.Age = rand.Next(0, 37);
                family.AddMember(person);
            }

            family.CalculateScore();
            FamilyService.Add(family);
        }

        Console.Clear();
        Console.WriteLine("10 Families, added successfully!");
        //Console.ReadKey();
    }

    public void ListFamilies()
    {
        List<Family> families = FamilyService.Browse().OrderByDescending(obj => obj.Score).ToList();
        Console.WriteLine("\nList all families: ");
        foreach (Family family in families)
        {
            Console.WriteLine($"Family: {family.Id}, Dependent Members: {family.DependentCount}, Income: ${family.TotalIncome.ToString("F2")}, Score: {family.Score}");
        }

        Console.ReadKey();
    }
}
