using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    //interfaz creada por si acaso
    public interface ICreate_Get <T>
    {
        void Create(T t);
        T[] FindAll();
    }
}
