using System;

namespace CustomerManagementTests.Exceptions
{
    // Custom exception to handle failed withdrawals
    public class FailedWithdrawalException : Exception
    {
        public string AccountType { get; }

        public FailedWithdrawalException(string message, string accountType)
            : base(message)
        {
            AccountType = accountType;
        }
    }
}
