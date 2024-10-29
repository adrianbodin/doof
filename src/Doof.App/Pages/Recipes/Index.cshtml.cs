using Doof.App.Data;
using Doof.App.Features.Recipes;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Doof.App.Pages.Recipes;

public class Recipes : PageModel
{
    private readonly ApplicationDbContext _context;

    public Recipes(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Recipe> Recipess { get; set; }

    public async Task OnGetAsync()
    {
        Recipess = await _context.Recipes.ToListAsync();

    }
}