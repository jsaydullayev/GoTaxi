namespace GoTaxi.Data.Contracts;
public interface IRepository<T>
{
    Task<T> Update(T entity);
    Task<T> Delete(T entity);
    Task<T> Add(T entity);
}
