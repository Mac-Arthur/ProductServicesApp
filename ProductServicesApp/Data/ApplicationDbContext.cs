using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProductServicesApp.Models;

namespace ProductServicesApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<ProductServicesApp.Models.Country> Country { get; set; } = default!;
        public DbSet<ProductServicesApp.Models.Company> Company { get; set; } = default!;
        public DbSet<ProductServicesApp.Models.Product> Product { get; set; } = default!;
    }
}
