using SportSystem.Data.Models.Enum;

namespace SportSystem.Data.Models
{
    public class Location
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }
        public Surface Surface { get; set; }
    }
}
