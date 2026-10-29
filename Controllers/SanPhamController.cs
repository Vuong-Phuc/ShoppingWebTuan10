using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingWebTuan10.Data;
using ShoppingWebTuan10.Models;

namespace ShoppingWebTuan10.Controllers
{
    public class SanPhamController : Controller
    {
        private readonly ShoppingDbContext _context;
        public SanPhamController(ShoppingDbContext context) => _context = context;

        public async Task<IActionResult> Index()
        {
            var list = await _context.SanPhams.Include(s => s.DanhMuc).ToListAsync();
            return View(list);
        }

      
    }
}