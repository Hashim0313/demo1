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
    public class AdminProfileModel : PageModel
    {
      public string AdminName { get; set; }

      public int Providercount { get; set; }
      public int SeekerCount { get; set; }
      public int JobsCount { get; set; }

        private readonly JobDbContext _context;

        public AdminProfileModel(JobDbContext context)
        {
            _context = context;
        }


      public void OnGet()
        {
            AdminName = HttpContext.Session.GetString("Name");

            JobsCount = _context.JobsInfo.Count();

            SeekerCount = _context.UsersInfo.Where(u=>u.role==Roles.SEEKER).Count();

            Providercount = _context.UsersInfo.Where(u => u.role == Roles.PROVIDER).Count();
        }
    }
}
