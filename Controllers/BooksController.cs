using Microsoft.AspNetCore.Mvc;

public class BooksController : Controller
{
    public BooksDbContext _context;
    public BooksController(BooksDbContext context)
    {
        _context = context;
    }
    public IActionResult GetBooksWithDatabase()
    {

        // veri tabanından books tablosundaki verileri çektik!!
        List<Book> books = _context.Books.ToList();

        return View();

    }
    public IActionResult GetBookNames()
    {

        // veri tabanından books tablosundaki verileri çektik!!
        // ÖNEMLİ NOT : Entity Frameworkte ihtiyacınız olan kadar veriyi çekmeniz entity framework performasnını artıracaktır

        List<BooksViewModel> books = _context.Books.Select(s => new BooksViewModel()
        {
            Id = s.Id,
            Name = s.Name,

        }).ToList();

        return View();

    }


}