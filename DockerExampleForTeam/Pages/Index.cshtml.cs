using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DockerExampleForTeam.Pages
{
    public class IndexModel : PageModel
    {
        

        public IndexModel()
        {
            
        }


        public void OnGet()
        {

        }

        public int Add(int x, int y)
        {
            return (x + y); 
        }
    }
}
