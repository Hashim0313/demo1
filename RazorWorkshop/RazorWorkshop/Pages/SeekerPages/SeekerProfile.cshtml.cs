using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWorkshop.Model;
using RazorWorkshop.Interface;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using RazorWorkshop.Dto;
using RazorWorkshop.Enums;




namespace RazorWorkshop.Pages.SeekerPages
{
    public class SeekerModel : PageModel
    {
        private readonly IJobServices _service;
        public SeekerModel(IJobServices service)
        {
            _service = service;
        }
        
      public string Name { get; set; }

        public List<JobDto> jobs { get; set; }


       public async Task OnGetAsync()
        {
            Name =  HttpContext.Session.GetString("Name");

          jobs = await  _service.GetAllJobsAsync();
        }

    }
}
