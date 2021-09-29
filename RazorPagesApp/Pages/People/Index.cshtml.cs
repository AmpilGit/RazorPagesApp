using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages.People
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationContext _context;
        public List<Person> People { get; set; }
        public Person anon { get; set; }
        public IndexModel(ApplicationContext db)
        {
            _context = db;
        }
        public static int counter = 0;
        public void OnGet()
        {
            People = _context.People.AsNoTracking().ToList();
            
        }
    }
}