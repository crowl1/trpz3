using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpz3.DAL.IMPL
{
    public class UnitOfWork
    {
        private readonly DeliveryData _deliveryData;
        private StorageRepository _StorageRepository;
        private OrderRepository _OrderRepository;
        private ManagerRepository _ManagerRepository;
        private GoodRepository _GoodRepository;
        private DriverRepository _DriverRepository;

        public UnitOfWork(DeliveryData context)
        {
            _deliveryData = context;
        }

        public StorageRepository Storages
        {
            get
            {
                if (_StorageRepository == null)
                    _StorageRepository = new StorageRepository(_deliveryData);
                return _StorageRepository;
            }
        }
        public OrderRepository Orders
        {
            get
            {
                if (_OrderRepository == null)
                    _OrderRepository = new OrderRepository(_deliveryData);
                return _OrderRepository;
            }
        }

        public ManagerRepository Managers
        {
            get
            {
                if (_ManagerRepository == null)
                    _ManagerRepository = new ManagerRepository(_deliveryData);
                return _ManagerRepository;
            }
        }

        public GoodRepository Goods
        {
            get
            {
                if (_GoodRepository == null)
                    _GoodRepository = new GoodRepository(_deliveryData);
                return _GoodRepository;
            }
        }

        public DriverRepository Drivers
        {
            get
            {
                if (_DriverRepository == null)
                    _DriverRepository = new DriverRepository(_deliveryData);
                return _DriverRepository;
            }
        }

        public void Save()
        {
            _deliveryData.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _deliveryData.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
