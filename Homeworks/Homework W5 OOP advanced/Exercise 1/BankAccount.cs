using System;
using System.Linq;
namespace Homework_W5_OOP_advanced.Exercise1
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        private decimal Balance { get; set; }

        private List<Transaction> Transactions { get; set; }

        public BankAccount(int accountNumber, string accountHolder, decimal balance)
        {
            AccountHolder = accountHolder;
            AccountNumber = accountNumber;
            Balance = balance;
            Transactions = new List<Transaction>();
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            var transaction = new Transaction
            {
                Amount = amount,
                Type = "Deposited",
                Timestamp = DateTime.Now
            };
            Transactions.Add(transaction);
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
            var transaction = new Transaction
            {
                Amount = amount,
                Type = "Withdrawed",
                Timestamp = DateTime.Now
            };
            Transactions.Add(transaction);
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public List<Transaction> GetTransactionHistory()
        {
            return Transactions.OrderBy(t => t.Timestamp).ToList();
        }
    }
}
