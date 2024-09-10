using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyDustyBookShelf.Models;

namespace MyDustyBookShelf.Pages
{
    public class BooksModel : PageModel
    {
        private readonly BookDBContext _context;

        public List<Book> Books { get; set; } = new List<Book>();

        [BindProperty]
        public Book NewBook { get; set; }

        public BooksModel(BookDBContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Books = _context.Books.ToList();
        }

        public IActionResult OnPost()
        {
            _context.Books.Add(NewBook);
            _context.SaveChanges();
            return RedirectToPage();
        }
    }
}
