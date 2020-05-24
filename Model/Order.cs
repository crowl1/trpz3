using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvc_wpf
{
    public class Order
    {
        private string _nameCustomer;
        private long _timeLeft;

        public string NameCustomer
        {
            get { return _nameCustomer; }
            set { _nameCustomer = value; }
        }
        public long TimeLeft
        {
            get { return _timeLeft; }
            set { _timeLeft = value; }
        }
    }
}
