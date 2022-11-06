using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTodayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsumeApi api = new ConsumeApi();
            api.GetAllCourses();
            Console.WriteLine("Enter the Course Id");
            int courseId = int.Parse(Console.ReadLine());
            api.GetCourseById(courseId);

            Console.WriteLine();
            Console.WriteLine("Enter Course Details");
            Console.WriteLine("Course Id");
            Course course = new Course();
            course.CourseId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Course Name");
            course.CourseName = Console.ReadLine();
            Console.WriteLine("Enter the Technology");
            course.Technology = Console.ReadLine();
            Console.WriteLine("Enter the Price");
            course.Price = int.Parse(Console.ReadLine());
            Console.WriteLine();
           api.PostNewCourse(course);
        }
    }
}
