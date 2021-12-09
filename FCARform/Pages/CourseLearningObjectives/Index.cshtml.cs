using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FCARform.Data;
using FCARform.Models;


namespace FCARform.Pages.CourseLearningObjectives
{
    public class IndexModel : PageModel
    {        
        private readonly FCARform.Data.ApplicationDbContext _context;
        
        public IndexModel(FCARform.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<CLO> CLO { get;set; }

        public async Task OnGetAsync()
        {
            CLO = await _context.CLOs.ToListAsync();
        }
    }
}