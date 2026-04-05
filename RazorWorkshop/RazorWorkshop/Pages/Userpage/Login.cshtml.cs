using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using RazorWorkshop.Model;
using RazorWorkshop.Interface;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using RazorWorkshop.Dto;
using RazorWorkshop.Enums;


namespace RazorWorkshop.Pages.Userpage
{

    public class LoginModel : PageModel
    {

        private readonly IAuthServices _service;


        public LoginModel (IAuthServices service)
        {
            _service = service;
        }



        [BindProperty]
        public UserLoginDto NewLogUser { get; set; }


        public async Task <IActionResult> OnPost()
        {

            var  user= await _service.Login(NewLogUser);

          HttpContext.Session.SetString("Name", user.Name);

            HttpContext.Session.SetString("Email", user.Email);
           
            HttpContext.Session.SetString("Role", user.role.ToString());

            if(user.role == Roles.ADMIN )
            {
                return RedirectToPage("/SeekerPages/AdminProfile");
            }


            if(user.role == Roles.SEEKER)
            {
                return RedirectToPage("/SeekerPages/SeekerProfile");
            }

            if (user.role == Roles.PROVIDER)
            {
                return RedirectToPage("/Job/Index");

            }

            return Page();
        }

        

    }
}
