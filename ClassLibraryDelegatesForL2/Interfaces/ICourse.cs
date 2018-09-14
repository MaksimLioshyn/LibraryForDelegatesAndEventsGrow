using ClassLibraryDelegatesForL2.Entities;

namespace ClassLibraryDelegatesForL2.Interfaces
{
    public interface ICourse: IServices<Course>
    {
        void Create(string name);
    }
}
