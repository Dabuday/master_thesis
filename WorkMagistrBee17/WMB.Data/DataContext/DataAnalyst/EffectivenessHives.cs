using System;
using System.Collections.Generic;
using System.Text;

namespace WMB.Data.DataContext.DataAnalyst
{
    public class EffectivenessHives
    {
        public int Id { get; set; }
        public string NameHive { get; set; } // название вулика
        public string descriptionHive { get; set; } // опис
        public DateTime zData { get; set; } // календар
        public double Effectiveness { get; set; } 
    }
}
