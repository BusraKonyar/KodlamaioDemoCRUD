using KodlamaioDemoCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemoCRUD.DataAccess.Abstract
{
    public interface ICategoryDal
    {
        void Add(Category category);
        void Update(Category category);
        void Delete(int categoryId);
        Category GetById(int id);
        List<Category> GetAll();
    }
}
