using Business.Abstract;
using Business.Concretes;
using DataAccess.Concretes;
using Entities.Categories;
using Entities.Persons;
using System;
using System.Collections.Generic;

namespace Workaround
{
    public class Program
    {
        static void Main(string[] args)
        {

            
                ICourseManager courseManager = new CourseManager(new CourseDal());
                List<Course> courses = courseManager.GetAll();
                foreach (Course course in courses)
                {
                    Console.WriteLine($"Course Id: {course.courseId}\nCourse Name: {course.courseName}");
                    Console.WriteLine("*************");
                }

                Course newCourse = new Course()
                {
                    courseId = 4,
                    courseName = "Programlamaya giriş için temel kurs",
                    instructor = "Engin"
                    
                };

                courseManager.Add(newCourse);

                courses = courseManager.GetAll();
                foreach (Course course in courses)
                {
                    Console.WriteLine($"Course Id: {course.courseId}\nCourse Name: {course.courseName}");
                    Console.WriteLine("*************");
                }

                Console.ReadLine();
            


        }
    }
}
