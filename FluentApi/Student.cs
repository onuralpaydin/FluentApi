using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CurrentGradeId { get; set; }
        public Grade CurrentGrade { get; set; }

        public virtual StudentAdress Adress { get; set; }
        public virtual ICollection<Course> Courses{ get; set; }

    }
}
