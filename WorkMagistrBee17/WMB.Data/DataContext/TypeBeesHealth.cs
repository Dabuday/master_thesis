using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMB.Data.DataContext
{
    public class TypeBeesHealth
    {
        public int Id { get; set; }
        public bool BeesHealth { get; set; } // тип вулика здоров'я
        public DateTime zDataDisease { get; set; }// дата збору
        public string Disease { get; set; } // Хвороба

        public ICollection<Beehive> Beehives { get; set; }
    }
}
