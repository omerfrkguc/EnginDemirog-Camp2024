using DataAccess.Abstacts;
using Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class CourseDal : ICoursesDal
    {

        List<Course> courses;

        public CourseDal() 
        {
            Course course1 = new Course()
            {
                instructor = "Engin",
                categoryId = 1,
                categoryName = "Programlama",
                courseId = 1,
                courseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)"
                
            };

            Course course2 = new Course()
            {   
                instructor = "Engin",
                categoryId = 1,
                categoryName = "Programlama",
                courseId = 2,
                courseName = "Senior Yazılım Geliştirici Yetiştirme Kampı"
            };

            Course course3 = new Course()
            {
                instructor = "Engin",
                categoryId = 1,
                categoryName = "Programlama",
                courseId = 3,
                courseName = "Senior Yazılım Geliştirici Yetiştirme Kamp2023 Yazılım Geliştirici Yetiştirme Kampı (Python + Selenium)"
            };

            courses = new List<Course> { course1, course2, course3 };
        }
        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(Course course)
        {
            courses.Remove(course);
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Update(Course course)
        {
            courses.Remove(course);
            courses.Add(course);
        }
    }
}
