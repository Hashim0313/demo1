using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorExercise.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace RazorExercise.Pages.Userpage
{
    public class UserProfileModel : PageModel
    {
        private readonly RazorExerciseContext _context;

        public UserProfileModel(RazorExerciseContext context)
        {
            _context = context;
        }

        public IList<AppliedJob> AppliedJobs { get; set; } = new List<AppliedJob>();

        public async Task<IActionResult> OnGetAsync()
        {
            var userId = HttpContext.Session.GetString("Name");
            if (userId == null)
            {
                // not logged in — redirect to login
                return RedirectToPage("/Userpage/Login");
            }

            var uid = userId.Value;

            AppliedJobs = await _context.AppliedJobs
                .AsNoTracking()
                .Where(a => a.UserId == uid)
                .Include(a => a.Job) // include Job entity
                .ToListAsync();

            return Page();
        }
    }
}