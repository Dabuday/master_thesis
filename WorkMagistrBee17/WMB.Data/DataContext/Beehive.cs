using System;

namespace WMB.Data.DataContext
{
    public class Beehive
    {
        /// Основна характеристика вулика
        public int Id { get; set; }
        public string NameHive { get; set; } // название вулика
        public string descriptionHive { get; set; } // опис
        public int NumberFrames { get; set; } // кількість рамок 
        /// ////////////////////////////////////////////////////////
        public int? TypeHiveId { get; set; } // тип вулика
        public TypeHive TypeHive { get; set; }
        /// ////////////////////////////////////////////////////////
        public int? TypeBeesId { get; set; } // тип бджоли
        public TypeBees TypeBees { get; set; }
        /// ////////////////////////////////////////////////////////
        public DateTime zData { get; set; }
        public string descriptionDate { get; set; } // опис
        public DateTime zData1 { get; set; } // календар
        public DateTime zData2 { get; set; }
        /// ////////////////////////////////////////////////////////
        public decimal PriceHive { get; set; } // цена вулика
        public double Coefficientefficiency { get; set; } // коэффициент эффективности
        public decimal PriceCostsHive { get; set; } // витрати на вулик
        /// ////////////////////////////////////////////////////////
        public int? UterusId { get; set; } // наявність матки
        public Uterus Uterus { get; set; }
        /// ////////////////////////////////////////////////////////
        public int? ProductTypeСollectionId { get; set; } // тип продукту збору
        public ProductTypeCollection ProductTypeСollection { get; set; }
        /// ////////////////////////////////////////////////////////
        public int? TypeBeesHealthId { get; set; } // тип вулика здоров'я
        public TypeBeesHealth TypeBeesHealth { get; set; }
        /// ////////////////////////////////////////////////////////
        public string ImagePath { get; set; }
    }
}
