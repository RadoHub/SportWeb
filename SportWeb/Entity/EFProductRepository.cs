using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportWeb.Entity
{
    public class EFProductRepository : IProductRepository
    {
        private ApplicationDbContext _context;
        public EFProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<Product> List
        {
            get
            {
                return _context.Products;
            }
        }
        //OR public IQueryable<Product> List => _context.Products; same as IQueryable<product> GetList() { return View (_context.Products); }
    }
}
