using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MapSample.Pages
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
    //public class MapsData
    //{
    //    //public MapsData(string countryName, string memberData)
    //    //{
    //    //    this.CountryName = countryName;
    //    //    this.Membership = memberData;
    //    //}
    //    public string Country { get; set; }
    //    public string Membership { get; set; }
    //}
}