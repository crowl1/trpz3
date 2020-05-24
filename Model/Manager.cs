using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvc_wpf
{
    public class Manager
    {
        private string _name;
        private long _executionTime;
        private long _releaseTime;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public long ExecutionTime
        {
            get { return _executionTime; }
            set { _executionTime = value; }
        }
        public long ReleaseTime
        {
            get { return _releaseTime; }
            set { _releaseTime = value; }
        }
    }
}
