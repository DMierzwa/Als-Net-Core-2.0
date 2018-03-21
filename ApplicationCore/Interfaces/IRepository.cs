
using System.Collections.Generic;

namespace ApplicationCore.Interfaces
{
    public interface IRepository<T>
    {
        T GetById(long id);

        List<T> List();

        T Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
