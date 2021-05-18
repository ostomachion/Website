using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Website.Areas.Chalk.Models;

namespace Website.Areas.Chalk.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<IGrouping<int, ChalkDrawing>> Drawings { get; }

        public IndexModel(ChalkDbContext context)
        {
            this.Drawings = context.ChalkDrawings.AsEnumerable().GroupBy(x => x.Date.Year);
        }
    }
}