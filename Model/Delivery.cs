﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace mvvc_wpf
{
    public class Delivery
    {


        public ObservableCollection<Order> Orders { get; set; }
        public ObservableCollection<Manager> Managers { get; set; }
        public ObservableCollection<Driver> Drivers { get; set; }
        public Delivery()
        {
            Orders = new ObservableCollection<Order>{};
            Managers = new ObservableCollection<Manager>
            {
                new Manager {ID = 0, Name = "Антон", ExecutionTime = 15, ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds()},
                new Manager {ID = 1, Name = "Анастасія", ExecutionTime = 25, ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds()},
                new Manager {ID = 2, Name = "Роман", ExecutionTime = 45, ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds()}
            };
            Drivers = new ObservableCollection<Driver>
            {
                new Driver {ID = 0, Name = "Олександр", MpS = 30, ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds()},
                new Driver {ID = 1, Name = "Роман", MpS = 20, ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds()},
                new Driver {ID = 2, Name = "Олексій", MpS = 50, ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds()},
                new Driver {ID = 3, Name = "Антон", MpS = 40, ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds()},
                new Driver {ID = 4, Name = "Андрій", MpS = 15, ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds()},
            };
        }

        public void orderProcessing(string Name, int meters, int TimeGood)
        {
            Orders.Insert(0, new Order { NameCustomer = Name, TimeLeft = TimeGood + Math.Min(ManagerCalculation(), DriverCalculation(meters)) });
            //MessageBox.Show(Orders[Orders.Count() - 1].NameCustomer + Convert.ToString(Orders[Orders.Count() - 1].TimeLeft));
        }

        List<long> manager_time = new List<long>();
        List<long> driver_time = new List<long>();


        public long ManagerCalculation()
        {
            manager_time.Clear();

            foreach (Manager m in Managers) //наповнюється додатковий список, який потрібен для знаходження min значення
            {
                manager_time.Add(m.ReleaseTime);
            }
            
            long time_left = manager_time.Min();


            foreach (Manager m in Managers)
            {
                if (m.ReleaseTime == time_left)
                {
                    if (DateTimeOffset.UtcNow.ToUnixTimeSeconds() >= m.ReleaseTime)
                    {
                        m.ReleaseTime += m.ExecutionTime;
                    }
                    else
                    {
                        m.ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + m.ExecutionTime;
                    }
                    return m.ReleaseTime;
                }
            }
            return 0;
        }


        public long DriverCalculation(int meters)
        {
            driver_time.Clear();

            foreach (Driver d in Drivers)
            {
                driver_time.Add(d.ReleaseTime);
            }

            long time_left = driver_time.Min();


            foreach (Driver d in Drivers)
            {
                if (d.ReleaseTime == time_left)
                {
                    if (DateTimeOffset.UtcNow.ToUnixTimeSeconds() >= d.ReleaseTime)
                    {
                        d.ReleaseTime += meters / d.MpS;
                    }
                    else
                    {
                        d.ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + meters / d.MpS;
                    }
                    return d.ReleaseTime;
                }
            }
            return 0;
        }
    }
}
