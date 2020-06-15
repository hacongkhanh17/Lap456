using Lap456.Models;
using System.Collections.Generic;

namespace Lap456.ViewModel
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}