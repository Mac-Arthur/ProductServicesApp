using ProductServicesApp.Models.Entities;

namespace ProductServicesApp.Models
{
    public class CompanyProduct
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public Product? Product { get; set; }
		public int CompanyId { get; set; }
		public Company? Company { get; set; }
		public bool IsExporter { get; set; }
		public bool IsImporter { get; set; }
	}
}
