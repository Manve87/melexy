using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Melexy.Models
{
    public class Wycieczka
    {
        public int id { get; set; }
        public Trasa trasa { get; set; }
        public DateTime start { get; set; }
        public decimal cena { get; set; }
        public List<Prowizja> prowizje { get; set; }
    }
}