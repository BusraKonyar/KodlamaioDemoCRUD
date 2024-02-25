using KodlamaioDemoCRUD.DataAccess.Abstract;
using KodlamaioDemoCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemoCRUD.DataAccess.Concreate
{
    public class CourseDal : ICourseDal
    {
        private List<Course> _courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "2024 C# Yazılım Geliştirici Kampı";
            course1.Description = "2024 C# Yazılım Geliştirici Kampını takip etmeyi unutmayın...";
            course1.Price = 10.5;
            course1.CategoryId = 1;
            course1.InstructorName = "Engin Demiroğ";

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "2022 JAVA Yazılım Geliştirici Kampı";
            course2.Description = "2022 JAVA Yazılım Geliştirici Kampını takip etmeyi unutmayın...";
            course2.Price = 0.0;
            course2.CategoryId = 1;
            course2.InstructorName = "Engin Demiroğ";

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "2023 Yazılım Geliştirici Yetiştirme Kampı Pyton&Selenyum";
            course3.Description = "Pyton&Selenyum Yazılım Geliştirici Yetiştirme Kampını takip etmeyi unutmayın... ";
            course3.Price = 90.85;
            course3.CategoryId = 1;
            course3.InstructorName = "Halit Enes Kalaycı";

            _courses = new List<Course> { course1, course2, course3 };
        }
        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(int courseId)
        {
            Course courseToDelete = _courses.FirstOrDefault(c => c.Id == courseId);
            if (courseToDelete != null)
            {
                _courses.Remove(courseToDelete);
            }
        }

        public List<Course> GetAll()
        {
            foreach (var course in _courses)
            {
                Console.WriteLine($"Kurs Adı: {course.Name}, Açıklama: {course.Description}, Eğitmen: {course.InstructorName}");
            }

            return _courses;
        }
        public Course GetById(int id)
        {
            return _courses.Find(x => x.Id == id);
        }

        public void Update(Course course)
        {
            Course courseToUpdate = _courses.FirstOrDefault(c => c.Id == course.Id);
            if (courseToUpdate != null)
            {

                courseToUpdate.Name = course.Name;
                courseToUpdate.Description =course.Description;
                courseToUpdate.Price = course.Price;
                courseToUpdate.CategoryId = course.CategoryId;
                courseToUpdate.InstructorName = course.InstructorName;
            }
            else
            {
                Console.WriteLine("Girdiğiniz id numaralı kurs mevcut olmadığı için güncelleme işlemi gerçekleştirilemedi!");
            }

        }
    }
}
