using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GanttSample.Pages
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
    public class GanttDataSource
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public int[] ResourceId { get; set; }
        public string Predecessor { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? Duration { get; set; }
        public int Progress { get; set; }
        public List<GanttDataSource> SubTasks { get; set; }
    }
    public class GanttResources
    {
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
    }
}