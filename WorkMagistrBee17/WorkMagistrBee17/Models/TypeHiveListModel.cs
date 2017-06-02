using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkMagistrBee17.Models
{
    public class TypeHiveListModel
    {
        public int Id { get; set; }

        [Display(Name = " TypeHive")]
        public string Name { get; set; }
    }
}
