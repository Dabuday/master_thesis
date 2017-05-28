using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMB.Data.DataContext
{
    public class ProductTypeCollection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; } // кг
        public DateTime zDataZbory { get; set; }// дата збору

        public ICollection<Beehive> Beehives { get; set; }
    }
}
