using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorExercise.Dto;
using RazorExercise.Interface;

namespace RazorExercise.Pages.Userpage
{
    public class RegisterModel : PageModel
    {
      
       

            private readonly IAuthService _service;


            public RegisterModel (IAuthService service)
            {
                _service = service;
            }


            [BindProperty]


            public RegisterDto NewUser { get; set; }


            public async Task <IActionResult> OnPost()
            {
                if(string.IsNullOrEmpty (NewUser.Name) ||  (string.IsNullOrEmpty(NewUser.Email)  || (string.IsNullOrEmpty(NewUser.Password))))
                {

                    ModelState.AddModelError("", "Email and Password Required");

                    return Page();

                }


                await _service.Register(NewUser);
                return RedirectToPage("/UserPage/Login");


            }



        }

    }

