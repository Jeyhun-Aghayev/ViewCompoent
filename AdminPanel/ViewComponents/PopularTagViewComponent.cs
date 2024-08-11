using CSharp.ViewComponentTask.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CSharp.ViewComponentTask.ViewComponents;

public class PopularTagViewComponent : ViewComponent
{
    private readonly ApplicationDbContext _context;
    public PopularTagViewComponent(ApplicationDbContext context) => _context = context;

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var tags = await _context.PopularTags.ToListAsync();
        return View(tags);
    }
}
