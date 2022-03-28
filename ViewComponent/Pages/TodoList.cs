using Microsoft.AspNetCore.Mvc;

namespace ASPCORE.Pages
{
    public class TodoList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}