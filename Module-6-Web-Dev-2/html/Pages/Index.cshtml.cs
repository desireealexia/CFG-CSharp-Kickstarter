using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace html.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string Username {get; set;}

    [BindProperty]
    public bool Newsletter {get; set;}

    public bool Submitted {get; set;}

    public void OnPost() {
        Submitted = true;
    }
}
