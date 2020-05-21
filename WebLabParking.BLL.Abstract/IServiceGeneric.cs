using System;
using System.Collections.Generic;

namespace WebLabParking.BLL.Abstract
{
    public interface IServiceGeneric<T>
    {
        void Create(T obj);
        T Read();
        IEnumerable<T> GetAll();
        void Update(T obj);
        void Delete(string name);
    }
}