namespace MvcCoreRazor.Models
{
    public class PersonModel
    {
        public long UniqueId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public Controllers.Sex Sex { get; set; }
    }
}