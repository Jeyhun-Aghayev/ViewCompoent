using CSharp.ViewComponentTask.Abstractions.Repositories;
using CSharp.ViewComponentTask.Data;
using CSharp.ViewComponentTask.Models;
using CSharp.ViewComponentTask.Data;


namespace CSharp.ViewComponentTask.Concretes.Repositories;

public class CategoryReadRepository : ReadRepository<Category>, ICategoryReadRepository
{
    public CategoryReadRepository(ApplicationDbContext context) : base(context)
    {
    }
}
