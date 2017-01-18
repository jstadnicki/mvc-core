namespace MvcCoreTodo.Controllers
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var list = new List<TodoItem>();
            list.Add(new TodoItem { Text = "Napisać na blogu" });
            list.Add(new TodoItem { Text = "Czytać przez 15 minut" });
            list.Add(new TodoItem { Text = "Ogarnąć prezentacje" });
            list.Add(new TodoItem { Text = "Umyć zęby" });

            return this.View("Index", list);
        }
    }

    public class TodoItem
    {
        public string Text { get; set; }
    }
}
