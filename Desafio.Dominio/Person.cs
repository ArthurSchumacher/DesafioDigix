namespace Desafio.Domain;

public class Person
{
    public int Age { get; set; }
    public Person()
    {
    }

    public Person(int age)
    {
        Age = age;
    }
}