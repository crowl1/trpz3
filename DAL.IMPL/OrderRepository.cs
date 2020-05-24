using mvvc_wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trpz3.DAL.Abstract;

namespace trpz3.DAL.IMPL
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(DeliveryData context) : base(context)
        {

        }
    }
}
