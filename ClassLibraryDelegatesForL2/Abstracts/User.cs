using System;

namespace ClassLibraryDelegatesForL2.Abstracts
{
    public abstract class User
    {
        public Guid Id { get; }
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public Account Account;

        protected User()
        {
            Id = Guid.NewGuid();
            Account = new Account();
        }
    }
}
