using ClassLibraryDelegatesForL2.Abstracts;

namespace ClassLibraryDelegatesForL2.Interfaces
{
    public interface IUser: IServices<User>
    {
        void Create(string firstName, string lastName);
    }
}
