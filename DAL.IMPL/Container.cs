using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpz3.DAL.IMPL
{
    public static class Container
    {
        private static DeliveryData _DeliveryData;
        public static DeliveryData DeliveryData
        {
            get => _DeliveryData;
            set
            {
                _DeliveryData = value;
                UnitOfWork = new UnitOfWork(_DeliveryData);
            }
        }
        public static UnitOfWork UnitOfWork { get; set; }
    }
}
