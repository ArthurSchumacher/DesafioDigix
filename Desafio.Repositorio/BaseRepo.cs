namespace Desafio.Repository;

public abstract class BaseRepo<TClass> where TClass : class
{
    public abstract TClass Create(TClass obj);

    public abstract TClass Delete(TClass obj);

    public abstract TClass ReadOne(int key);

    public abstract List<TClass> ReadAll();
}
