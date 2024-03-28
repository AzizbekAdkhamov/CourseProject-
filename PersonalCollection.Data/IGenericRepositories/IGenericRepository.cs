using PersonalCollection.Domain.Commons;
using System.Linq.Expressions;

namespace PersonalCollection.Data.IGenericRepositories;
public interface IGenericRepository<T> where T : Auditable 
{
    Task<T> CreateAsync(T entity);

    Task<T> UpdateAsync(T entity);

    Task<bool> DeleteAsync(int Id);

    Task<T> GetAsync(int Id);

    IQueryable<T> GetAllAsync(Expression<Func<T, bool>> expression,
        bool istracking = true);
}
