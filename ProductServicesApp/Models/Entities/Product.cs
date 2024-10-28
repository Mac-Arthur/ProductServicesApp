namespace ProductServicesApp.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public List<CompanyProduct>? CompanyProducts { get; set; } = new(); // new HashSet<CompanyProduct>();
    }
}
