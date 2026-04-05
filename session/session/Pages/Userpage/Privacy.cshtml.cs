using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using session.Models;

namespace session.Pages.Userpage
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
            

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }


        public void OnGet()
        {

        }


    }
}
