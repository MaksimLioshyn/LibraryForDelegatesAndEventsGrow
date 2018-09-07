namespace ClassLibraryDelegatesForL2
{
    public class Account
    {
        public delegate string AccountStateHandler(string message);
        public event AccountStateHandler Withdrawn;
        public event AccountStateHandler Added;

        public int Sum { get; set; }
        public string Message { get; private set; }

        public void OnAdded(int sum)
        {
            Sum += sum;
            Message = Added?.Invoke($"The account has arrived {sum}");
        }

        public void Withdraw(int sum)
        {
            if (sum <= Sum)
            {
                Sum -= sum;
                Message =  Withdrawn?.Invoke($"The amount of {sum} was withdrawn from the account");
            }
            else
            {
                Message = Withdrawn?.Invoke("There is not enough money on the account");
            }
        }
        
    }
}
