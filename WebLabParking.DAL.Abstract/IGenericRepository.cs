using System;
using System.Collections.Generic;
using System.Text;

namespace WebLabParking.DAL.Abstract
{
    public interface IGenericRepository<T>
    {
        void Create(T obj);
        T Read();
        IEnumerable<T> GetAll();
        void Update(T obj);
        void Delete(string name);

    }
}
