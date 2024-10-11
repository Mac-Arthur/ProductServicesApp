namespace ProductServicesApp.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? CompanyMail { get; set; }
        public string? ContactPersonName { get; set; }
        public string? ContactPersonMail { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool IsActive { get; set; }
        public int CountryId { get; set; }
        public Country? Country { get; set; }

    }
}
