using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriTabanı
{
    internal class Ogrenci
    {
        [Key]
        public int  Id { get; set; }
        public int okulno { get; set; }
        public string ad { get; set; }
        public  string soyad { get; set; }


    }
}
