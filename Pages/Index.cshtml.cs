using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string InputString1 { get; set; }

    [BindProperty]
    public string InputString2 { get; set; }

    public string ComparisonResult { get; set; }

    public IActionResult OnPost()
    {
        ComparisonResult = CompareStrings(InputString1, InputString2) ?
            "The length of both strings are equal and also, both strings are equal." :
            "The strings are not equal.";

        return Page();
    }

    private bool CompareStrings(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i])
            {
                return false;
            }
        }

        return true;
    }
}
