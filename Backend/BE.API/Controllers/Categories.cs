using BE.DAL.EF;
using Microsoft.AspNetCore.Mvc;

namespace BE.API.Controllers
{
    public class Categories : Controller
    {
 
        private readonly NDbContext _context;

        public CategoriesController(NDbContext context)
        {
            _context = context;
        }
        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categories>>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
