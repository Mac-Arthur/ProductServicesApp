using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProductServicesApp.Models;
using ProductServicesApp.Models.Entities;

namespace ProductServicesApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
	{
		public DbSet<Country> Country { get; set; } = default!;
		public DbSet<Company> Company { get; set; } = default!;
		public DbSet<Product> Product { get; set; } = default!;
		public DbSet<ProductServicesApp.Models.CompanyProduct> CompanyProduct { get; set; } = default!;


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<CompanyProduct>()
			.HasOne(cp => cp.Company)
		   .WithMany(c => c.CompanyProducts)
		   .HasForeignKey(cp => cp.CompanyId)
		  .OnDelete(DeleteBehavior.NoAction);

			modelBuilder.Entity<CompanyProduct>()
				.HasOne(cp => cp.Product)
				.WithMany(p => p.CompanyProducts)
				.HasForeignKey(cp => cp.ProductId)
				.OnDelete(DeleteBehavior.NoAction);
		}


	}
}




