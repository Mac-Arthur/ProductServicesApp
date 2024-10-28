namespace ProductServicesApp.Models
{
	public class GetProductDTO
	{
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public string? Country { get; set; }
        public string? CompanyName { get; set; }
        public bool IsExporter { get; set; }
        public bool IsImporter { get; set; }

    }
}
