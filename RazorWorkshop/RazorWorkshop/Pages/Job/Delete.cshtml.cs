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
    public class DeleteModel : PageModel
    {
        private readonly IJobServices _service;

        public DeleteModel (IJobServices service)
        {
            _service = service;
        }

        [BindProperty]

        public JobDto JobPost { get; set; }

        public async Task <IActionResult> OnGetAsync(int id)
        {
            JobPost = await _service.GetJobByIdAsync(id);

            if (JobPost == null)
            {
                return NotFound();
            }

            return Page();

        }


        public async Task <IActionResult> OnPostAsync(int id)
        {
            await _service.DeleteJobAsync(id);
            return RedirectToPage("Index");
        }


    }
}
