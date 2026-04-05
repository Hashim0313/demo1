using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorExercise.Dto;
using RazorExercise.Interface;

namespace RazorExercise.Pages.Userpage
{
    public class LoginModel : PageModel
    {
        private readonly IAuthService _service;



        public LoginModel (IAuthService service)
        {
            _service = service;
        }


        [BindProperty]


        public LoginDto NewLogUser { get; set; }


        public async Task <IActionResult> OnPost()
        {

            var user = await _service.Login(NewLogUser);

            HttpContext.Session.SetString("Name", user.Name);

            HttpContext.Session.SetInt32("UserID", user.UserID);

           return RedirectToPage("/UserPage/UserProfile");
        }








    }
}
