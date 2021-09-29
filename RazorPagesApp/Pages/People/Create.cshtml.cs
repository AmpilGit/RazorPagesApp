using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages.People
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationContext _context;
        [BindProperty]
        public Person Person { get; set; }
        public CreateModel(ApplicationContext db)
        {
            _context = db;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                _context.People.Add(Person);
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}