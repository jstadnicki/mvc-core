namespace MvcCoreTodo.Controllers
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        private readonly static List<TodoItem> tasks = new List<TodoItem>();

        [HttpGet]
        public ActionResult Index()
        {
            return this.View("Index", tasks);
        }

        [HttpGet]
        public ActionResult AddTask()
        {
            return this.View("AddTask");
        }

        [HttpPost]
        public ActionResult AddTask(TodoItem item)
        {
            if (this.ModelState.IsValid)
            {
                tasks.Add(item);
                return this.RedirectToAction("Index");
            }

            return this.View("AddTask");
        }
    }

    public class TodoItem
    {
        [Required]
        public string Text { get; set; }
    }
}
