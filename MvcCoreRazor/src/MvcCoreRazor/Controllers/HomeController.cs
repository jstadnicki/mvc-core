namespace MvcCoreRazor.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        private readonly Models.PersonModel person;

        public HomeController()
        {
            this.person = new Models.PersonModel
            {
                UniqueId = 123234,
                FirstName = "Jarek",
                LastName = "Stadnicki",
                Country = "Polska",
                City = "Wrocław",
                Sex = Sex.Male
            };
        }

        public ActionResult Index()
        {
            return this.View(person);
        }

        public ActionResult Secret()
        {
            return this.View("ThisIsTotalyDifferentView", person);
        }

        public ActionResult IDontNeedModel()
        {
            return this.View();
        }

        public ActionResult WithoutLayout()
        {
            return this.View(person);
        }

        public ActionResult ReallyWithoutLayout()
        {
            return this.View(person);
        }

        public ActionResult NoMatchingViewFound()
        {
            return this.View();
        }
    }
}