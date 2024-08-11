using CSharp.ViewComponentTask.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharp.ViewComponentTask.Abstractions.Repositories;

public interface IRepository<T> where T : BaseEntity, new()   //Marker Pattern
{
    DbSet<T> Table { get; }
}


