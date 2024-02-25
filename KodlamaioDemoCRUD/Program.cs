using KodlamaioDemoCRUD.Business.Concreate;
using KodlamaioDemoCRUD.DataAccess.Concreate;
using KodlamaioDemoCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemoCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseManager courseManager = new CourseManager(new CourseDal());
            CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            InstructorManager instructorManager = new InstructorManager(new InstructorDal());
            // Tüm kurslar
            Console.WriteLine("Tüm kurslar:");
            courseManager.GetAll();

            //Kurs Ekleme
            Course newCourse = new Course { Id = 4, Name = "Yeni Course", Description = "Yeni kursu takip edin", CategoryId = 1, InstructorName = "Büşra Konyar" };
            courseManager.Add(newCourse);
            Console.WriteLine("Yeni kurs eklendi.");
            courseManager.GetAll();

            //Kurs Güncelleme
            Course courseToUpdate = courseManager.GetById(4);
            courseToUpdate.Name = "Güncellenen Kurs";
            courseToUpdate.Description = "Güncellenen Kurs takip edin";
            courseToUpdate.CategoryId = 1;
            courseToUpdate.InstructorName = "Kadir Konyar";
            courseManager.Update(courseToUpdate);
            Console.WriteLine("Kurs güncellendi.");
            courseManager.GetAll();

            //Kurs silme
            int courseIdToDelete = 4;
            courseManager.Delete(courseIdToDelete);
            Console.WriteLine($"ID'si {courseIdToDelete} olan kurs silindi.");
            courseManager.GetAll();

            // Tüm kategoriler
            Console.WriteLine("Tüm Kategoriler:");
            categoryManager.GetAll();

            //Kategori Ekleme
            Category newCategory = new Category { Id = 2, Name = "Kişisel Gelişim" };
            categoryManager.Add(newCategory);
            Console.WriteLine("Yeni kategori eklendi.");
            categoryManager.GetAll();

            //Kategori Güncelleme
            Category categoryToUpdate = categoryManager.GetById(2);
            categoryToUpdate.Name = "Güncellenen Kategori";
            categoryManager.Update(categoryToUpdate);
            Console.WriteLine("Kategori güncellendi.");
            categoryManager.GetAll();

            //Kategori Silme
            int categoryIdToDelete = 2;
            categoryManager.Delete(categoryIdToDelete);
            Console.WriteLine($"ID'si {categoryIdToDelete} olan kategori silindi.");
            categoryManager.GetAll();

            //Tüm Eğitmenler
            Console.WriteLine("Tüm eğitmenler:");
            instructorManager.GetAll();

            //Eğitmen Ekleme
            Instructor newInstructor = new Instructor { Id = 3, FirstName = "Büşra", LastName = "Konyar" };
            instructorManager.Add(newInstructor);
            Console.WriteLine("Yeni eğitmen eklendi.");
            instructorManager.GetAll();

            //Eğitmen Güncelleme
            Instructor instructorToUpdate = instructorManager.GetById(3);
            instructorToUpdate.FirstName = "Kadir";
            instructorToUpdate.LastName = "Konyar";
            instructorManager.Update(instructorToUpdate);
            Console.WriteLine("Eğitmen güncellendi.");
            instructorManager.GetAll();

            //Eğitmen Silme
            int instructorIdToDelete = 3;
            instructorManager.Delete(instructorIdToDelete);
            Console.WriteLine($"ID'si {instructorIdToDelete} olan eğitmen silindi.");
            instructorManager.GetAll();

            Console.ReadKey();
        }
    }
}
