namespace MvcCoreTodo.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View("Index");
        }
    }
}
