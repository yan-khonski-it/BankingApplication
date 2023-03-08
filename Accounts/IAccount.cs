using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Accounts
{
    [JsonDerivedType(typeof(NamedAccount))]
    internal interface IAccount
    {

        public int Balance
        { get; }

        public void Deposit(int ammount);

        public void Withdraw(int ammount);
    }
}
