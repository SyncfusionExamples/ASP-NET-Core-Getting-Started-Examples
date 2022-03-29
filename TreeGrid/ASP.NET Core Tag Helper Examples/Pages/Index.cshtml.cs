using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TreeGridSample.Pages
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
    public class TreeGridItems
    {
        public TreeGridItems() { }
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public DateTime StartDate { get; set; }
        public int Duration { get; set; }
        public List<TreeGridItems> Children { get; set; }

        public static List<TreeGridItems> GetTreeData()
        {
            List<TreeGridItems> BusinessObjectCollection = new List<TreeGridItems>();

            TreeGridItems Record1 = null;

            Record1 = new TreeGridItems()
            {
                TaskId = 1,
                TaskName = "Planning",
                StartDate = new DateTime(2016, 06, 07),
                Duration = 5,
                Children = new List<TreeGridItems>(),
            };
            TreeGridItems Child1 = new TreeGridItems()
            {
                TaskId = 2,
                TaskName = "Plan timeline",
                StartDate = new DateTime(2016, 06, 07),
                Duration = 5
            };

            TreeGridItems Child2 = new TreeGridItems()
            {
                TaskId = 3,
                TaskName = "Plan budget",
                StartDate = new DateTime(2016, 06, 07),
                Duration = 5
            };
            TreeGridItems Child3 = new TreeGridItems()
            {
                TaskId = 4,
                TaskName = "Allocate resources",
                StartDate = new DateTime(2016, 06, 07),
                Duration = 5
            };
            Record1.Children.Add(Child1);
            Record1.Children.Add(Child2);
            Record1.Children.Add(Child3);
            TreeGridItems Record2 = new TreeGridItems()
            {
                TaskId = 6,
                TaskName = "Design",
                StartDate = new DateTime(2021, 08, 25),
                Duration = 3,
                Children = new List<TreeGridItems>()
            };
            TreeGridItems Child5 = new TreeGridItems()
            {
                TaskId = 7,
                TaskName = "Software Specification",
                StartDate = new DateTime(2021, 08, 25),
                Duration = 3
            };

            TreeGridItems Child6 = new TreeGridItems()
            {
                TaskId = 8,
                TaskName = "Develop prototype",
                StartDate = new DateTime(2021, 08, 25),
                Duration = 3
            };
            TreeGridItems Child7 = new TreeGridItems()
            {
                TaskId = 9,
                TaskName = "Get approval from customer",
                StartDate = new DateTime(2024, 06, 27),
                Duration = 2
            };
            Record2.Children.Add(Child5);
            Record2.Children.Add(Child6);
            Record2.Children.Add(Child7);
            BusinessObjectCollection.Add(Record1);
            BusinessObjectCollection.Add(Record2);
            return BusinessObjectCollection;
        }
    }
}