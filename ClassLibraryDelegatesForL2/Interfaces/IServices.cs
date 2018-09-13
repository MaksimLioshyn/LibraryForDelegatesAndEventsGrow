using System;

namespace ClassLibraryDelegatesForL2.Interfaces
{
    public interface IServices<T> where T: class 
    {
        void Create();
        void Delete(Guid id);
        T Edit(Guid id);
        T FindMaterialById(Guid id);
    }
}
