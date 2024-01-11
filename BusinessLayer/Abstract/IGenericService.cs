using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void BusinessInsert(T entity);
        void BusinessUpdate(T entity);
        void BusinessDelete(T entity);
        List<T> BusinessGetAll();
        T BusinessGetById(int id);
        List<T> BusinessGetWhere(Expression<Func<T, bool>> expression);

    }
}
