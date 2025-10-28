using System;
using CustomerManagementTests.Model;
using CustomerManagementTests.Exceptions;

namespace CustomerManagementTests.Model
{
    // Base Account class with exception handling
    public class Account
    {
        public int Id { get; set; }
        public decimal Balance { get; protected set; }
        public string LastTransactionInfo { get; protected set; }

        public Account(decimal startBalance)
        {
            Balance = startBalance;
            LastTransactionInfo = $"Account created. Balance: {Balance}";
        }

        public virtual void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive.");

            Balance += amount;
            LastTransactionInfo = $"Deposit: {amount}; New balance: {Balance}";
        }

        public virtual bool Withdraw(Customer who, decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive.");

            if (Balance >= amount)
            {
                Balance -= amount;
                LastTransactionInfo = $"Withdraw: {amount}; New balance: {Balance}";
                return true;
            }
            else
            {
                LastTransactionInfo = "Failed withdraw: not enough balance";

                // Throw custom exception
                throw new FailedWithdrawalException(
                    $"Withdrawal of {amount} failed due to insufficient balance.",
                    this.GetType().Name
                );
            }
        }

        public virtual decimal AddInterest()
        {
            LastTransactionInfo = "Interest not available for this account";
            return 0m;
        }

        public virtual string Info()
        {
            return $"Account Id: {Id}; Balance: {Balance}";
        }
    }
}
