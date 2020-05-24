using mvvc_wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trpz3.DAL.Abstract;

namespace trpz3.DAL.IMPL
{
    public class ManagerRepository : GenericRepository<Manager>, IManagerRepository
    {
        public ManagerRepository(DeliveryData context) : base(context)
        {

        }
    }
}
