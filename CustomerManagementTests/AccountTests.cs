using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerManagementTests.Model;
using CustomerManagementTests.Exceptions;

namespace CustomerManagementTests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void Deposit_ShouldIncreaseBalance()
        {
            var acc = new Account(100m);
            acc.Deposit(50m);
            Assert.AreEqual(150m, acc.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Deposit_ShouldThrowForNegativeAmount()
        {
            var acc = new Account(100m);
            acc.Deposit(-20m);
        }

        [TestMethod]
        public void Withdraw_ShouldReduceBalance_WhenSufficientFunds()
        {
            var acc = new Account(200m);
            var customer = new Customer("Alice");

            bool result = acc.Withdraw(customer, 100m);

            Assert.IsTrue(result);
            Assert.AreEqual(100m, acc.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(FailedWithdrawalException))]
        public void Withdraw_ShouldThrowFailedWithdrawalException_WhenInsufficientFunds()
        {
            var acc = new Account(50m);
            var customer = new Customer("Bob");

            acc.Withdraw(customer, 100m); // triggers custom exception
        }

        [TestMethod]
        public void Info_ShouldReturnFormattedString()
        {
            var acc = new Account(500m) { Id = 1 };
            string info = acc.Info();
            Assert.IsTrue(info.Contains("Account Id: 1"));
            Assert.IsTrue(info.Contains("Balance: 500"));
        }
    }
}
