using CSharp.ViewComponentTask.Abstractions.Repositories;
using CSharp.ViewComponentTask.Data;
using CSharp.ViewComponentTask.Models;
using CSharp.ViewComponentTask.Data;
using Microsoft.EntityFrameworkCore;

namespace CSharp.ViewComponentTask.Concretes.Repositories;

public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity, new()
{
    private readonly ApplicationDbContext _context;

    public WriteRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    #region Create
    public void Add(T entity)
    {
        Table.Add(entity);
    }
    public async Task AddAsync(T entity)
    {
        await Table.AddAsync(entity); //=> Code tərəfdə Add prosesin getməsi üçün
    }


    #endregion

    #region Save
    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync(); //DbSet tərəfində olan dəyişikliklərin DataBase'ə də tətbiq olunması üçün.
    }


    #endregion

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }
    public void Delete(T entity)
    {
        throw new NotImplementedException();
    }

}
