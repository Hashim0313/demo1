using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWorkshop.Model;
using RazorWorkshop.Interface;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using RazorWorkshop.Dto;





namespace RazorWorkshop.Pages.Userpage
{
    public class RegisterModel : PageModel
    {
        private readonly IAuthServices _service;

        public RegisterModel(IAuthServices service)
        {
            _service = service;
        }



        [BindProperty]

        public UserRegisterDto NewUser { get; set; }


     
        public async Task <IActionResult> OnPost()
        {
            if (string.IsNullOrEmpty (NewUser.Name) || (string.IsNullOrEmpty(NewUser.Email)  || (string.IsNullOrEmpty(NewUser.Password))))
                {
                ModelState.AddModelError("", "Email and Password required");

                return Page();
            }


          await _service.Register(NewUser);
            return RedirectToPage("/Userpage/Login");


        }








    }
}
