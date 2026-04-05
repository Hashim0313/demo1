using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWorkshop.Helper;
using RazorWorkshop.Interface;
using RazorWorkshop.Model;
using RazorWorkshop.Repository;
using RazorWorkshop.Service;
using Microsoft.EntityFrameworkCore;
using RazorWorkshop.Dto;



namespace RazorWorkshop.Pages.Job
{
    public class EditModel : PageModel
    {
        private readonly IJobServices _service;

        [BindProperty]

        public JobDto JobPost { get; set; }



        public EditModel (IJobServices service)
        {
            _service = service;
        }


        public async Task <IActionResult> OnGetAsync(int id)
        {
            var jobDto = await _service.GetJobByIdAsync(id);
            if (jobDto == null)
            {
                return NotFound();
            }

            JobPost = jobDto;
            return Page();

        }


        public async Task <IActionResult> OnPostAsync()
        {
            await _service.UpdateJobAsync(JobPost.ID, JobPost);
            return RedirectToPage("Index");
        }


    }
}
