using ClassLibraryDelegatesForL2.Entities;
using NUnit.Framework;

namespace ClassLibraryDelegatesForL2Tests
{
    [TestFixture()]
    public class MaterialStudentTests
    {
        public delegate void Deleg();

        [Test()]
        public void MaterialTest()
        {
            Student[] users = new Student[]
            {
                new Student("FirstName", "LastName") { Account = { Sum = 50 } },
                new Student("FirstName", "LastName") { Account = { Sum = 150 } },
                new Student("FirstName", "LastName") { Account = { Sum = 250 } }
            };

            string[] strings = new string[3];
            //Material material1 = new Material("Material 1");
            //Material material2 = new Material("Material 2");
            //Material material3 = new Material("Material 3");

            //user.Account.Added += material1.Message;
            //user.Account.Added += material2.Message;
            //user.Account.Added += material3.Message;

            Deleg deleg = null;
            foreach (Student user in users)
            {
                user.Account.Added += message => $"The account has arrived {user.Account.Sum}";
                deleg += user.Account.OnAdded;
            }

            deleg?.Invoke();
            for (int i = 0; i < users.Length; i++)
            {
                strings[i] = users[i].Account.Message;
            }

            //Assert.Fail();
        }

       
    }
}