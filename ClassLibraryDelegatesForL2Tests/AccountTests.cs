using ClassLibraryDelegatesForL2;
using NUnit.Framework;

namespace ClassLibraryDelegatesForL2Tests
{
    [TestFixture()]
    public class AccountTests
    {

        [TestCase(150, ExpectedResult = "The account has arrived 150")]
        [TestCase(250, ExpectedResult = "The account has arrived 250")]
        [TestCase(350, ExpectedResult = "The account has arrived 350")]
        public string OnAddedTest(int sum)
        {
            Account account = new Account(200);
            account.Added += Show_Message;
            account.OnAdded(sum);
            return account.Message;
        }

        [TestCase(50, ExpectedResult = "The amount of 50 was withdrawn from the account")]
        [TestCase(150, ExpectedResult = "The amount of 150 was withdrawn from the account")]
        [TestCase(250, ExpectedResult = "There is not enough money on the account")]
        [TestCase(350, ExpectedResult = "There is not enough money on the account")]
        public string WithdrawTest(int sum)
        {
            Account account = new Account(200);
            account.Withdrawn += Show_Message;
            account.Withdraw(sum);
            return account.Message;
        }

        private static string Show_Message(string message)
        {
            return message;
        }
    }
}