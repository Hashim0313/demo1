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
    public class CreateModel : PageModel
    {
        private readonly IJobServices _service;


        [BindProperty]

        public JobDto JobPost { get; set; }

        public CreateModel (IJobServices service)
        {
            _service = service;
        }


        public async Task <IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _service.AddJobAsync(JobPost);
            return RedirectToPage("Index");
        }


    }
}
