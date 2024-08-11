using CSharp.ViewComponentTask.Abstractions.Repositories;
using CSharp.ViewComponentTask.Data;
using CSharp.ViewComponentTask.Models;
using CSharp.ViewComponentTask.Data;



namespace CSharp.ViewComponentTask.Concretes.Repositories;

public class CategoryWriteRepository : WriteRepository<Category>, ICategoryWriteRepository
{
    public CategoryWriteRepository(ApplicationDbContext context) : base(context)
    {
    }
}
