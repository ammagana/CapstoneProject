using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OrderCookDeliver.Pages
{
    public class ShoppingCartModel : PageModel
    {
        public string Cart{
            get;set;
        }
        public void OnGet()
        {

        }
        
    }
}