using System;

namespace Tap2021Demo.Console
{


    /*public class AtmSingleton
    {
        private readonly DebitAccount _debitAccount;
        private static readonly AtmSingleton _instance=new AtmSingleton();
        private AtmSingleton()
        {
            _debitAccount = new DebitAccount();
        }
        public static AtmSingleton Instance => _instance;

        public DebitAccount DebitAccount => _debitAccount;
        

    }*/
    class Program
    {
        private const int Amount = 500;
        static void Main(string[] args)
        {
            //AtmSingleton.Instance.DebitAccount.Deposit(100);

            //Prepare
            var account = new SavingsAccount(); // am creat o instanta 
            account.Deposit(200); //depun bani 
            var card = new Card("Andrei Ionut");
            card.AddAcount(account);

            //withdraw from atm
            Atm.Instance.Insert(card);
            Atm.Instance.SelectAccount(account);
            Atm.Instance.WithDraw(100);


            /* System.Console.WriteLine($"Disponibil { account.Balance} RON");
            
            try
            {
                account.Withdraw(100);

            }
            catch(InvalidOperationException)
            {
                System.Console.WriteLine("Fonduri insuficiente");
            }
            System.Console.WriteLine($"Disponibil {account.Balance} RON");
            */

        }
    }
}
