using CSharp.ViewComponentTask.Models;

namespace CSharp.ViewComponentTask.Abstractions.Repositories;

public interface IReadRepository<T> : IRepository<T> where T : BaseEntity, new()   //Marker Pattern
{
}


