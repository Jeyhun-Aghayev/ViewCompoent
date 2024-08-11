using CSharp.ViewComponentTask.Abstractions.Repositories;
using CSharp.ViewComponentTask.Models;
using CSharp.ViewComponentTask.Data;
using Microsoft.EntityFrameworkCore;

namespace CSharp.ViewComponentTask.Concretes.Repositories;

public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity, new()
{
    private readonly ApplicationDbContext _context;

    public ReadRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();


}