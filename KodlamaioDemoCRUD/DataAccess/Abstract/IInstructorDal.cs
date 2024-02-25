using KodlamaioDemoCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemoCRUD.DataAccess.Abstract
{
    public interface IInstructorDal
    {
        void Add(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(int instructorId);
        Instructor GetById(int id);
        List<Instructor> GetAll();
    }
}
