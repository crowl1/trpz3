using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvvc_wpf;

namespace trpz3.DAL.IMPL
{
    class DeliveryData
    {
        public class DelivaryData : DbContext
        {
            public DelivaryData() : base(ConfigurationManager.ConnectionStrings["DataBaseConnection"].ConnectionString)
            {
            }

            public DbSet<Order> Orders { get; set; }
            public DbSet<Storage> Storages{ get; set; }
            public DbSet<Manager> Managers{ get; set; }
            public DbSet<Good> Goods{ get; set; }
            public DbSet<Driver> Drivers{ get; set; }

        }
    }
}
