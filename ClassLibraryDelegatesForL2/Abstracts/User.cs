using ClassLibraryDelegatesForL2.Entities;
using System;

namespace ClassLibraryDelegatesForL2.Abstracts
{
    public abstract class User
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DateOfBirth { get; set; } = new DateTime();
        public Account Account { get; set; } = new Account();

        protected User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        protected User()
        {
        }
    }
}
