using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi
{
    internal class OgrenciAdres
    {
        [Key]
        public int OgrenciAdresId { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }


        public int OgrenciId { get; set; }

        [ForeignKey("OgrenciId")]
        public virtual Ogrenci Ogrenci { get; set; }
    }
}
