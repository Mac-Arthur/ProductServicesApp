namespace ProductServicesApp.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ShortCode { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool IsActive { get; set; }

    }
}
