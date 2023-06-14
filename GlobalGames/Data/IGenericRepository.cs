using System.Threading.Tasks;

namespace GlobalGames.Data
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T entity);

        Task<bool> ExistAsync(int id);
    }
}
