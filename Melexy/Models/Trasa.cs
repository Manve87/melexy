using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Melexy.Models
{
    public class Trasa
    {
        public int id { get; set; }
        public string nazwa { get; set; }
        public int czas { get; set; }
        public decimal domyslnaCena { get; set; }
    }
}