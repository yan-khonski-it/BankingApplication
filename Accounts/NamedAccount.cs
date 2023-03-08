using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public class NamedAccount : BaseAccount
    {
        public string Owner
        { get; }

        public NamedAccount(string owner)
        {
            this.Owner = owner;
        }
    }
}
