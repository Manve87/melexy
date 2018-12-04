using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Melexy.Models
{
    public class Prowizja
    {
        int Id { get; set; }
        public Pracownik pracownik { get; set; }
        public decimal procent { get; set; } 
        public decimal prowizja { get; set; }
        public DateTime data { get; set; }
        public decimal kwota { get; set; }
    }
}