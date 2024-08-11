using CSharp.ViewComponentTask.Models;

namespace CSharp.ViewComponentTask.Abstractions.Repositories;

public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity, new()   //Marker Pattern
{
    void Add(T entity);
    Task AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);

    Task SaveAsync();
}


