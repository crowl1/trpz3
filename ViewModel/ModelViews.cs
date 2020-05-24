using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using trpz3.Infrastructure;

namespace mvvc_wpf
{
    class ModelViews : INotifyPropertyChanged
    {
        Delivery delivery = new Delivery();


        private Good _selectedGood;
        public ObservableCollection<Good> Goods { get; set; }
        public Good SelectedGood
        {
            get { return _selectedGood; }
            set
            {
                _selectedGood = value;
                OnPropertyChanged("SelectedGood");
            }
        }


        private string _customer;
        public string Сustomer
        {
            get { return _customer; }
            set 
            {
                _customer = value;
                OnPropertyChanged("Сustomer");
            }

        }


        private Storage _selectedStorage;
        public ObservableCollection<Storage> Storages { get; set; }
        public Storage SelectedStorage
        {
            get { return _selectedStorage; }
            set
            {
                _selectedStorage = value;
                OnPropertyChanged("SelectedStorage");
            }
        }


        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      delivery.orderProcessing(Сustomer, SelectedStorage.Distance, SelectedGood.ExecutionTime);
                  }));
            }
        }






        public ModelViews()
        {
            Storages = new ObservableCollection<Storage>
            {
                new Storage {Name = "Київський склад", Distance = 10},
                new Storage {Name = "Одеський склад", Distance = 50},
                new Storage {Name = "Рівненський склад", Distance = 25}
            };

            Goods = new ObservableCollection<Good>
            {
                new Good {Name = "Молоко", ExecutionTime = 450},
                new Good {Name = "Хліб", ExecutionTime = 200},
                new Good {Name = "Торти", ExecutionTime = 1000}
            };
        }




        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }


    }
}
