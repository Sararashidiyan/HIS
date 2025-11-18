namespace Company.SharedKernel
{
    public interface ICommandRepository<TKey,T> where T : class
    {
        Task DeleteAsync(T item);
        Task CreateAsync(T item);
        Task ModifyAsync(T item);
    }

    public interface IQueryRepository<TKey, T> where T : class
    {
        Task<T> GetByIdAsync(TKey id);
        Task<List<T>> GetAllAsync();
    }
}
