using System;

namespace ClassLibraryDelegatesForL2
{
    public class User
    {
        public Guid Id { get; private set; }
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;

        public Account Account;
        public Material Material;

        public User()
        {
            Id = Guid.NewGuid();
            Account = new Account();
            Material = new Material();
        }
    }
}
