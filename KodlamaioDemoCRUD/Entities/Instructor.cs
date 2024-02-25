using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemoCRUD.Entities
{
    public class Instructor:BaseEntitiy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> CourseId { get; set; }
    }
}
