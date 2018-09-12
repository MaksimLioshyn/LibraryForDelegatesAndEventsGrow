using ClassLibraryDelegatesForL2.Abstracts;
using ClassLibraryDelegatesForL2.Concrete;
using NUnit.Framework;

namespace ClassLibraryDelegatesForL2Tests
{
    [TestFixture()]
    public class AccountStudentTests
    {

        [TestCase(150, ExpectedResult = "The account has arrived 150")]
        [TestCase(250, ExpectedResult = "The account has arrived 250")]
        [TestCase(350, ExpectedResult = "The account has arrived 350")]
        public string OnAddedTest(int sum)
        {
            User user = new Student();
            user.Account.Added += ShowMessage;
            user.Account.OnAdded(sum);
            return user.Account.Message;
        }

        [TestCase(50, ExpectedResult = "The amount of 50 was withdrawn from the account")]
        [TestCase(150, ExpectedResult = "The amount of 150 was withdrawn from the account")]
        [TestCase(250, ExpectedResult = "There is not enough money on the account")]
        [TestCase(350, ExpectedResult = "There is not enough money on the account")]
        public string WithdrawTest(int sum)
        {
            User user = new Student { Account = { Sum = 200 } };
            user.Account.Withdrawn += ShowMessage;
            user.Account.Withdraw(sum);
            return user.Account.Message;
        }

        private static string ShowMessage(string message)
        {
            return message;
        }

        private string CombineMessage(User user)
        {
            return ShowMessage($"The account has arrived {user.Account.Sum}");
        }
    }
}