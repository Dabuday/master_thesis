using System;
using System.Collections.Generic;
using System.Text;
using WMB.Data.DataContext;
using WMB.Data.IRepositorys;

namespace WMB.Data.Repository
{
    public class BeehiveRepository : IRepository
    {
        public List<Beehive> GetBeehive()
        {
            return new List<Beehive>
            {
                new Beehive {PriceCostsHive=6, descriptionHive="6789"},
            };
        }
    }
}
