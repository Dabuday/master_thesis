using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkMagistrBee17.Models
{
    public class BeehiveListModel
    {
        public int Id { get; set; }

        public int? TypeHiveId { get; set; }
        public string TypeHive { get; set; }

        public int? TypeBeesId { get; set; }
        public string TypeBees { get; set; }

        [Display(Name = " NameHive")]
        public string NameHive { get; set; }

        [Display(Name = "descriptionHive")]
        public string descriptionHive { get; set; }

        [Display(Name = "NumberFrames")]
        public int NumberFrames { get; set; }

        [Display(Name = "В у zData")]
        public DateTime zData { get; set; }

        [Display(Name = "descriptionDate")]
        public string descriptionDate { get; set; }

        [Display(Name = "В у zData")]
        public DateTime zData1 { get; set; }

        [Display(Name = "В у zData")]
        public DateTime zData2 { get; set; }

        [Display(Name = "PriceHive")]
        public decimal PriceHive { get; set; }

        [Display(Name = "Coefficientefficiency")]
        public double Coefficientefficiency { get; set; }

        [Display(Name = "PriceCostsHive")]
        public decimal PriceCostsHive { get; set; }

        public int? UterusId { get; set; }
        public string Uterus { get; set; }

        public int? ProductTypeСollectionId { get; set; }
        public string ProductTypeСollection { get; set; }

        public int? TypeBeesHealthId { get; set; }
        public string TypeBeesHealth { get; set; }

        [Display(Name = "Опис")]
        public string Description { get; set; }
    }
}
