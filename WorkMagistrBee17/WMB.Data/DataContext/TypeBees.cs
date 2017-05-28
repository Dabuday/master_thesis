using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMB.Data.DataContext
{
    public class TypeBees
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Beehive> Beehives { get; set; }
    }
}
