using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvc_wpf
{
    public class Driver
    {
        private string _name;
        private long _mps;
        private long _releaseTime;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public long MPS
        {
            get { return _mps; }
            set { _mps = value; }
        }
        public long ReleaseTime
        {
            get { return _releaseTime; }
            set { _releaseTime = value; }
        }
    }
}
