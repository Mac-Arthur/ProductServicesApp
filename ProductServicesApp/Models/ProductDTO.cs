namespace ProductServicesApp.Models
{
    public class ProductDTO
    {
        public string? Name { get; set; }
        public bool IsExporter { get; set; }
        public bool IsImporter { get; set; }
        public int ProductId { get; set; }
        public int CompanyId { get; set; }
    

    }
}
