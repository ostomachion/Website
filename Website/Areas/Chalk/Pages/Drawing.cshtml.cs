using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Website.Areas.Chalk.Models;

namespace Website.Areas.Chalk.Pages
{
    public class DrawingModel : PageModel
    {
        private readonly ChalkDbContext context;

        public ChalkDrawing Drawing { get; set; }

        public DrawingModel(ChalkDbContext context)
        {
            this.context = context;
        }

        public IActionResult OnGet(string name)
        {
            Drawing = this.context.ChalkDrawings.FirstOrDefault(x => x.PathName == name);
            return Drawing is null ? NotFound() : Page();
        }
    }
}