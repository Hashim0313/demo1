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
    public class IndexModel : PageModel
    {
        private readonly IJobServices _service;

        public List<JobDto> JobPosts { get; set; }


        public IndexModel (IJobServices service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            JobPosts = await _service.GetAllJobsAsync();
        }





    }
}
