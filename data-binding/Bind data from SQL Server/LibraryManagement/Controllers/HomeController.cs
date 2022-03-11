using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Syncfusion.EJ2.Base;

namespace LibraryManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly LibraryContext _context;

        public HomeController(LibraryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult UrlDatasource([FromBody] DataManagerRequest dm)
        {
            IEnumerable<Book> DataSource = _context.Books.ToList();
            int count = DataSource.Cast<Book>().Count();
            return Json(new { result = DataSource, count = count });
        }


        public ActionResult Insert([FromBody] ICRUDModel<Book> value)
        {
            _context.Books.Add(value.Value);
            _context.SaveChanges();
            return Json(value);
        }

        public IActionResult Update([FromBody] ICRUDModel<Book> value)
        {
            //do stuff
            var ord = value;

            Book val = _context.Books.Where(or => or.Id == ord.Value.Id).FirstOrDefault();
            val.Id = ord.Value.Id;
            val.Name = ord.Value.Name;
            val.Author = ord.Value.Author;
            val.Quantity = ord.Value.Quantity;
            val.Price = ord.Value.Price;
            val.Available = ord.Value.Available;
            _context.SaveChanges();
            return Json(value);
        }

        public IActionResult Delete([FromBody] ICRUDModel<Book> value)
        {
            //do stuff
            Book order = _context.Books.Where(c => c.Id == (int)value.key).FirstOrDefault();
            _context.Books.Remove(order);
            _context.SaveChanges();
            return Json(order);
        }

        public class ICRUDModel<T> where T : class
        {
            public int? key { get; set; }
            public T Value { get; set; }
        }

    }
}