using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Localization.Pages
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

        public List<CultureDetails> Cultures = new List<CultureDetails>() 
        {
            new CultureDetails(){ ID = "en-US", Text = "English" },
            new CultureDetails(){ ID = "de", Text = "Germany" },
            new CultureDetails(){ ID = "fr", Text = "French" },
            new CultureDetails(){ ID = "zh", Text = "Chinese" }
        };

        public class CultureDetails
        {
            public string ID { get; set; }
            public string Text { get; set; }
        }
    }
}