using KodlamaioDemoCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemoCRUD.DataAccess.Abstract
{
    public interface ICourseDal
    {
        void Add(Course course);

        void Update(Course course);
        void Delete(int courseId);
        Course GetById(int id);
        List<Course> GetAll();
    }
}
