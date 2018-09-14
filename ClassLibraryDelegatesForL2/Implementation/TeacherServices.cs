using ClassLibraryDelegatesForL2.Abstracts;
using ClassLibraryDelegatesForL2.Entities;
using ClassLibraryDelegatesForL2.Interfaces;
using System;

namespace ClassLibraryDelegatesForL2.Implementation
{
    public class TeacherServices: IUser
    {
        public User Create() => new Teacher();
        public User Create(string firstName, string lastName) => new Teacher(firstName, lastName);

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public User Edit(Guid id)
        {
            throw new NotImplementedException();
        }

        public User FindById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
