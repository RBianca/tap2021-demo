using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tap2021Demo.Console
{
    public class Atm
    {
        private static Atm _instance = new Atm();
        private Card _card;
        private Account _account;

        private Atm()
        {
            System.Console.WriteLine("New Instance of ATM");
        }
        public static Atm Instance
        {
            get
            {
                if(_instance==null)
                {
                    _instance = new Atm();
                }
                return _instance;
            }
        }
        public void Insert(Card card)
        {
            _card = card;
        }

        public void SelectAccount(Account account)
        {
            var acc = _card.Accounts.Single(a => a == account);
          _account = acc;
        }

        public void WithDraw(decimal amount)
        {
            _account.Withdraw(amount);
            System.Console.WriteLine($" Amount {amount} was withdraw from the account");
            System.Console.WriteLine($"Remaining: {_account.Balance}");
        }
        public void Eject(Card card)
        {

        }
    }
}
