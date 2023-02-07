using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi
{
    [Table("tbl_Ogrenci")]
    internal class Ogrenci
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }

        [NotMapped]
        public string BusraCeren { get; set; }


    
        public virtual OgrenciAdres OgrenciAdres { get; set; }
    }
}
