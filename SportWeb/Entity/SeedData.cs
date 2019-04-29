using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportWeb.Entity
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();

            if(!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee { EmployeeName="Orhan", EmployeeSurname="Veli" },
                    new Employee { EmployeeName="Cengiz",EmployeeSurname="Under"},
                    new Employee { EmployeeSurname="Can", EmployeeName="Ciger"}
                    );
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product { Name = "Ryzen 2700x", Description = "CPU of AMD", Category = "PC", Price = 300 },
                    new Product { Name = "Macbook Air", Description = "Laptop of Apple", Category = "Laptop", Price = 2000 },
                    new Product { Name = "Aspire 3", Description = "Laptop of Acer", Category = "Notebooks", Price = 1100 },
                    new Product { Name = "Nintendo", Description = "Game Console of Nintendo", Category = "Consoles", Price = 400 },
                    new Product { Name = "Play Station 4", Description = "Game Console of Sony", Category = "Consoles", Price = 1300 },
                    new Product { Name = "Ryzen 1700x", Description = "CPU of AMD", Category = "PC", Price = 250},
                    new Product { Name = "Intel i9 9900k", Description = "Garbage of Intel", Category = "PC", Price = 999 },
                    new Product { Name = "XBox 360", Description = "Game Console of MS", Category = "Consoles", Price = 1300 }
                                         );
            }
            context.SaveChanges();
        }
    }
}
