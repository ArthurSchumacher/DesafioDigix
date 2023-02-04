using System.Collections.Generic;
namespace Desafio.Domain;

public class Family
{
    public int Id { get; set; }
    public double TotalIncome { get; set; }
    public int Score { get; set; }
    public List<Person> FamilyMembers { get; set; }
    public int DependentCount { get; set; }

    public Family()
    {
        FamilyMembers = new List<Person>();
    }

    public Family(double totalIncome)
    {
        TotalIncome = totalIncome;
        Score = 0;
        FamilyMembers = new List<Person>();
    }

    public void AddMember(Person newMember)
    {
        FamilyMembers.Add(newMember);
    }

    public void RemoveMember(Person familyMember)
    {
        FamilyMembers.Remove(familyMember);
    }

    public void CalculateScore()
    {
        if (Score == 0)
        {
            CalculateDependents(FamilyMembers);

            if (TotalIncome <= 900)
            {
                Score += 5;
            }

            if (TotalIncome >= 901 && TotalIncome <= 1500)
            {
                Score += 3;
            }

            if (DependentCount >= 3)
            {
                Score += 3;
            }

            if (DependentCount > 0 && DependentCount <= 2)
            {
                Score += 2;
            }
        }
    }

    private void CalculateDependents(List<Person> familyMembers)
    {
        foreach (Person dependent in familyMembers)
        {
            if (dependent.Age <= 18)
            {
                DependentCount += 1;
            }
        }
    }
}
