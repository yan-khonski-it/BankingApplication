namespace Accounts
{
    internal interface IAccount
    {

        public int Balance
        { get; }

        public void Deposit(int ammount);

        public void Withdraw(int ammount);
    }
}
