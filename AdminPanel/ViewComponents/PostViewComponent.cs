using CSharp.ViewComponentTask.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CSharp.ViewComponentTask.ViewComponents;

public class PostViewComponent : ViewComponent
{
    private readonly ApplicationDbContext _context;
    public PostViewComponent(ApplicationDbContext context) => _context = context;

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var posts = await _context.Posts.ToListAsync();
        return View(posts);
    }
}