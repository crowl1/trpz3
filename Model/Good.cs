using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace mvvc_wpf
{
    public class Good : INotifyPropertyChanged
    {
        private string _name;
        private int _executionTime;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public int ExecutionTime
        {
            get { return _executionTime; }
            set
            {
                _executionTime = value;
                OnPropertyChanged("ExecutionTime");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
