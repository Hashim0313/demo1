using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorExercise.Dto;
using RazorExercise.Interface;
using RazorExercise.Models;
using Microsoft.EntityFrameworkCore;

namespace RazorExercise.Pages.Userpage
{
    public class AppliedJobsModel : PageModel
    {


        public static int Ajobs { get; set; }

        public int userid { get; set; }

        public AppliedJob _Jobs=new AppliedJob();

        private readonly RazorExerciseContext _context;


        public AppliedJobsModel (RazorExerciseContext context)
        {
            _context = context;
        }


        public void OnGetAsync(int id)
        {

            Ajobs = id;

            userid = int.Parse(HttpContext.Session.GetInt32("UserID").ToString());

        }

        public async Task OnPostAsync()
        {
            OnGetAsync(Ajobs);

            _Jobs.UserId = userid;

            _Jobs.JobId = Ajobs;

            await _context.AppliedJobs.AddAsync(_Jobs);

            _context.SaveChanges();


        }





    }
}
