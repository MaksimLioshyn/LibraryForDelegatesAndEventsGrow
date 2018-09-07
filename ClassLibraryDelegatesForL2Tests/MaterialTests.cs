using ClassLibraryDelegatesForL2;
using NUnit.Framework;

namespace ClassLibraryDelegatesForL2Tests
{
    [TestFixture()]
    public class MaterialTests
    {
        [Test()]
        public void MaterialTest()
        {
            User user = new User();
            Material material1 = new Material("Material 1");
            Material material2 = new Material("Material 2");
            Material material3 = new Material("Material 3");

            user.Account.Added += material1.Message;
            user.Account.Added += material2.Message;
            user.Account.Added += material3.Message;


            //Assert.Fail();
        }
    }
}