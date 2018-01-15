using Als_Net_Core_2.Data;
using Als_Net_Core_2.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Als_Net_Core_2.Pages
{
    public class IndexModel : PageModel
    {
        private MySqlContext _db;

        public IList<League> Leagues { get; set; }

        public IndexModel(MySqlContext db)
        {
            _db = db;
        }

        public async Task OnGetAsync()
        {
            Leagues = await _db.Leagues.ToListAsync();
        }
    }
}