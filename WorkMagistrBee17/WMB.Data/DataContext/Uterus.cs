using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMB.Data.DataContext
{
    public class Uterus
    {
        public int Id { get; set; }
        public bool Uteru { get; set; } // наявність матки
        public DateTime zDataAgeUterus { get; set; }// дата заселення

        public ICollection<Beehive> Beehives { get; set; }
    }
}
