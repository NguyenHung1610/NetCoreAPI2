using Microsoft.AspNetCore.Mvc;
using Lesson6.Data;
using Lesson6.Models;

public class ProductController : Controller
{
    private readonly AppDbContext _context;

    public ProductController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var products = _context.Products.ToList();
        return View(products);
    }
}