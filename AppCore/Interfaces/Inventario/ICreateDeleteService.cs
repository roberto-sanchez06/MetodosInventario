using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces.Inventario
{
    public interface ICreateDeleteService<T>
    {
        void Add(T t);
        bool Delete(T t);
    }
}
