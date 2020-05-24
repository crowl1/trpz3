using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using trpz3.DAL.Abstract;

namespace trpz3.DAL.IMPL
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DeliveryData _deliveryData;

        public GenericRepository(DeliveryData deliveryData)
        {
            _deliveryData = deliveryData;
        }

        public void Delete(T entity)
        {
            _deliveryData.Set<T>().Remove(entity);
            _deliveryData.SaveChanges();
        }

        public T Get(int id)
        {
            return _deliveryData.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _deliveryData.Set<T>().Add(entity);
            _deliveryData.SaveChanges();
        }

        public List<T> ListEntities()
        {
            return _deliveryData.Set<T>().ToList();
        }

        public List<T> ListEntities(Expression<Func<T, bool>> expression)
        {
            return _deliveryData.Set<T>().Where(expression).ToList();
        }

        public void Update(T entity)
        {
            _deliveryData.Entry<T>(entity).State = EntityState.Modified;
            _deliveryData.SaveChanges();
        }
    }
}
