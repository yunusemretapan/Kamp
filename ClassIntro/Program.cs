using System;
using System.Collections.Generic;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null) {
                throw new ArgumentNullException(nameof(args));
            }

            List<Course> courses = new List<Course> {
              new Course {
                  CourseName = "C#",
                  Instructor = "Engin Demiroğ",
                  ViewRate = 68
              }
            };

            foreach (var item in courses) {
                Console.WriteLine(item.CourseName);
            }
        }
    }

    class Course {
        public string CourseName { get; set; }
        public string Instructor { get; set; }
        public int ViewRate { get; set; }
    }
}
