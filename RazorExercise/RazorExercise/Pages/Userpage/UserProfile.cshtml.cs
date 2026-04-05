using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorExercise.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace RazorExercise.Pages.Userpage
{
    public class UserProfileModel : PageModel
    {

        public string Name { get; set; }

        private readonly RazorExerciseContext _context;

        public UserProfileModel(RazorExerciseContext context)
        {
            _context = context;
        }

        public IList<Job> Jobs { get; set; } 

        public async Task<IActionResult> OnGetAsync()
        {
            Name = HttpContext.Session.GetString("Name");

            Jobs = await _context.Jobs.ToListAsync();

            return Page();
        }
    }
}


