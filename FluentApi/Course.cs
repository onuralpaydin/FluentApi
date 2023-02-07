using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi
{
    internal class Course
    {
        public int CourseId { get; set; }
        public int CourseName { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
