using System;
using System.Collections.Generic;
using System.Text;

namespace Tap2021Demo.Console
{
    public class Card
    {
        public Card(string cardHolder)
        {
            Holder = cardHolder;
            Accounts = new List<Account>();
        }
        public string Holder { get; private set; }
        public IEnumerable<Account> Accounts { get; private set; }

        internal void AddAcount(SavingsAccount account)
        {
            (Accounts as List<Account>).Add(account);
        }
    }
}
