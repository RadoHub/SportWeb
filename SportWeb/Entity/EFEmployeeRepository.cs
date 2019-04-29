using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportWeb.Entity
{
    public class EFEmployeeRepository : IEmployeeRepository
    {
        private ApplicationDbContext _context;

        public EFEmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<Employee> List => _context.Employees;
    }
}
