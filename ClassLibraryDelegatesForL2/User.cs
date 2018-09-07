using System;

namespace ClassLibraryDelegatesForL2
{
    public class User
    {
        public Guid Id { get; }
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public Account Account;

        public User()
        {
            Id = Guid.NewGuid();
            Account = new Account();
        }
    }
}
