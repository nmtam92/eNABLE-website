using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eNABLE_website.Pages
{
    public class FundingModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Your contact page.";
        }
    }
}
