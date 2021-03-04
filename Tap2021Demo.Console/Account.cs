using System;

namespace Tap2021Demo.Console
{
    public abstract class Account
    {
        public decimal Balance { get; private set; } //decimal in loc de double 
        /*
         asta poate fi scrisa si asa:
        public decimal balance;
        public decimal GetBalance()
        { return balance;}
        public void SetBalance(decimal value)
        {balance=value;}
        */
        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
        public decimal Withdraw(decimal amount)
        {
            var fee = CalculateWithdrawalFee(amount);
            amount += fee;
            if (Balance < amount)
            {
                throw new InvalidOperationException("Insufficient funds!");
            }
            this.Balance -= amount;
            return amount;
        }
        protected abstract decimal CalculateWithdrawalFee(decimal amount);
    }
}
