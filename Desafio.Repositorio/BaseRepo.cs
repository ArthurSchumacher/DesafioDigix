namespace Desafio.Repository;

public interface BaseRepo<TClass> where TClass : class
{
    public abstract TClass Create(TClass obj);

    public abstract TClass Delete(TClass obj);

    public abstract TClass ReadOne(int key);

    public abstract List<TClass> ReadAll();
}
