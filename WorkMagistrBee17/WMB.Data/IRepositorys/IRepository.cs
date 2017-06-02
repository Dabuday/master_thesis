using System;
using System.Collections.Generic;
using System.Text;
using WMB.Data.DataContext;

namespace WMB.Data.IRepositorys
{
    public interface IRepository
    {
        List<Beehive> GetBeehive();
    }
}
