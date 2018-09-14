using System;
using System.Collections.Generic;
using ClassLibraryDelegatesForL2.Entities;

namespace ClassLibraryDelegatesForL2.Interfaces
{
    public interface IServices<T> where T: class 
    {
        void Create();
        bool Delete(Guid id);
        T Edit(T course);
        T FindById(Guid id);
        IEnumerable<T> GetAll();
    }
}
