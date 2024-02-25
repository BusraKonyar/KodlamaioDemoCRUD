using KodlamaioDemoCRUD.DataAccess.Abstract;
using KodlamaioDemoCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemoCRUD.DataAccess.Concreate
{
    public class CategoryDal : ICategoryDal
    {
        private List<Category> _categories;

        public CategoryDal()
        {

            _categories = new List<Category>
            {
                new Category { Id = 1, Name = "Proglamlama" }
               
            };
        }

        public List<Category> GetAll()
        {
            foreach (var category in _categories)
            {
                Console.WriteLine($"Kategori Adı: {category.Name}");
            }

            return _categories;
        }

      

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        

        public void Delete(int id)
        {
            Category categoryToDelete = _categories.FirstOrDefault(c => c.Id == id);
            if (categoryToDelete != null)
            {
                _categories.Remove(categoryToDelete);
            }
        }

        public void Update(Category category)
        {
            Category categoryToUpdate = _categories.FirstOrDefault(c => c.Id ==category.Id);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
            }
            else
            {
                Console.WriteLine("Girdiğiniz id numaralı kategori mevcut olmadığı için güncelleme işlemi gerçekleştirilemedi!");
            }
        }

        public Category GetById(int id)
        {
           return _categories.Find(x => x.Id == id);
        }
    }

  
}
