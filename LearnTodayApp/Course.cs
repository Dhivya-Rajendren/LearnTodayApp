using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTodayApp
{
    public class Course
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public string Technology { get; set; }
        public int DurationInHours { get; set; }
        public int Price { get; set; }
        public string CourseImg { get; set; }
    }
}
