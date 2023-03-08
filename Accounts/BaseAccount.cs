using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public class BaseAccount : IAccount
    {
        public int Balance
        { get; private set; }

        public void Deposit(int ammount)
        {
            Balance += ammount;
        }

        public void Withdraw(int ammount)
        {
            Balance -= ammount;
        }
    }
}
