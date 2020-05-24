using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace trpz3.DAL.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        T Get(int id);
        List<T> ListEntities();
        List<T> ListEntities(Expression<Func<T, bool>> expression);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
