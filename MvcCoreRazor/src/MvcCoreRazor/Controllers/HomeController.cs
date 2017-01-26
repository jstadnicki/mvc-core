namespace MvcCoreRazor.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var person = new PersonModel
            {
                UniqueId = 123234,
                FirstName = "Jarek",
                LastName = "Stadnicki",
                Country = "Polska",
                City = "Wrocław",
                Sex = Sex.Male
            };

            return this.View("Index", person);
        }


        public ActionResult Secret()
        {
            var person = new PersonModel
            {
                UniqueId = 123234,
                FirstName = "Jarek",
                LastName = "Stadnicki",
                Country = "Polska",
                City = "Wrocław",
                Sex = Sex.Male
            };

            return this.View("Secret", person);
        }
    }

    public class PersonModel
    {
        public long UniqueId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public Sex Sex { get; set; }
    }

    public enum Sex
    {
        Unknown = 0,
        Male = 1,
        Female = 2
    }
}