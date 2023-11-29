namespace Pin.HowestMusic.Services.Interfaces
{
    public interface ICrudService<T> where T : class
    {
        Task<IQueryable<T>> GetAllAsync();
        Task<T> GetAsync(Guid id);
        Task CreateAsync(T item);
        Task UpdateAsync(T item);
        Task DeleteAsync(Guid id);
    }
}
