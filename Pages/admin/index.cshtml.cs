using Fade_Lounge.Model;
using Fade_Lounge.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fade_Lounge.Pages.admin;

public class indexx : PageModel

    {
        private IKundeRepository _kundes;

        public Kunde KundeLoggedIn {  get; private set; }

        public indexx(IKundeRepository kundes)
        {
            _kundes = kundes;
        }

        public IActionResult OnGet()
        {
            if (_kundes is null || _kundes.KundeLoggedIn is null || !_kundes.KundeLoggedIn.isadmin) {
                return RedirectToPage("/Login");
            }

            KundeLoggedIn = _kundes.KundeLoggedIn;   

            return Page();
        }
    }




    