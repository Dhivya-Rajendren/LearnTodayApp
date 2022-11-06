using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LearnTodayApp
{
    internal class ConsumeApi
    {

        public void GetAllCourses()
        {
            using (var client= new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("https://localhost:44360/api/Course");
                Console.WriteLine(Environment.NewLine+result);
            }
        }

        public void GetCourseById(int courseId)
        {
            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("https://localhost:44360/api/Course/GetById/"+courseId);
                Console.WriteLine(Environment.NewLine + result);
            }
        }

        public void PostNewCourse(Course course)
        {
            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                var result = client.UploadString("https://localhost:44360/api/Course",JsonConvert.SerializeObject(course));
                Console.WriteLine( result);
            }
        }
    }
}
