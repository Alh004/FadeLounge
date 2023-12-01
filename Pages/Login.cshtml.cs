using Fade_Lounge.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fade_Lounge.Pages;

public class Loginmodel : PageModel
{
    
    private IKundeRepository _kundeRepository;

    public Loginmodel(IKundeRepository _kundeRepository)
    {
        _kundeRepository = _kundeRepository;
    }



    [BindProperty]
    public string Email { get; set; }

    [BindProperty]
    public string Adgangskode { get; set; }

    public void OnGet()
    {
    }
    public IActionResult OnPost()
    {
        if (Email == null || Adgangskode == null)
        {
            return Page();
        }

        if (!_kundeRepository.CheckKunde(Email, Adgangskode))
        {
            return Page();
        }

        return RedirectToPage("Index");
    }
}
    }
}