using Microsoft.EntityFrameworkCore;
using PersonalCollection.Data.DbContexts;
using PersonalCollection.Data.IGenericRepositories;
using PersonalCollection.Domain.Commons;
using System.Linq.Expressions;

namespace PersonalCollection.Data.GenericRepositories;
public class GenericRepository<T>(AppDbContext appDbContext) : IGenericRepository<T> where T : Auditable
{
    private readonly AppDbContext _appDbContext = appDbContext;
    private readonly DbSet<T> _dbset = appDbContext.Set<T>();
    public async Task<T> CreateAsync(T entity)
    {
        var entry = await _dbset.AddAsync(entity);
        await _appDbContext.SaveChangesAsync();
        return entry.Entity;
    }

    public async Task<bool> DeleteAsync(int Id)
    {
        var entityToDelete = await _dbset.FirstOrDefaultAsync(u =>  u.Id == Id);
        var isdeleted =  _dbset.Remove(entityToDelete);
        if (isdeleted == null)
            return false;    
        return await _appDbContext.SaveChangesAsync() > 0 ;
    }

    public IQueryable<T> GetAllAsync(Expression<Func<T, bool>> expression, bool istracking = true)
    {
        var query = _dbset.Where(expression);
        if (!istracking)
            query = query.AsNoTracking();
        return query;
    }

    public async Task<T> GetAsync(int Id)
       => await _dbset.FirstOrDefaultAsync(e => e.Id == Id);
    

    public async Task<T> UpdateAsync(T entity)
    {
        var entry = _appDbContext.Update(entity);
        await _appDbContext.SaveChangesAsync();
        return entry.Entity;

    }
}
