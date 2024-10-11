namespace ProductServicesApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsExporter { get; set; }
        public bool IsImporter { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int CompanyId { get; set; }
        public Company? Company { get; set; }


    }
}
