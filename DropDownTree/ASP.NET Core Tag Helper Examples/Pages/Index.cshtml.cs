using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DropDownTreeSample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
    public class Parent
    {
        public string nodeId;
        public string nodeText;
        public string icon;
        public bool expanded;
        public bool selected;
        public List<Child> nodeChild;
    }
    public class Child
    {
        public string nodeId;
        public string nodeText;
        public string icon;
        public bool expanded;
        public bool selected;
        public List<Child> nodeChild;
    }
}