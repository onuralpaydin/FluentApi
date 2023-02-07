using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi
{
    internal class StudentAdress
    {
        public int StudentAdressId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }


        public int? AddressofStudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
