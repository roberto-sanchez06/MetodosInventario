using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Metodos
{
    public interface ICreateDeleteModel<T>
    {
        void Add(T t);
        bool Delete(T t);
    }
}
