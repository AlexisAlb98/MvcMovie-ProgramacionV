using Microsoft.AspNetCore.Mvc;
using MvcMovie.Data;
using MvcMovie.Models;

public class Movies2Controller : Controller
{
    private readonly MoviesContext _context;

    public Movies2Controller(MoviesContext context)
    {
        _context = context;
    }

    // GET: Movie/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Movie/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,Genre,Price")] Movie movie)
    {
        if (ModelState.IsValid)
        {
            _context.Add(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Create)); // Redirige de vuelta a la acción Create
        }
        return View(movie);
    }

}