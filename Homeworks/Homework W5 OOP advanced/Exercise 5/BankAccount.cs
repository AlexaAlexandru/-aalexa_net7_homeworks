using System;
namespace Homework_W5_OOP_advanced.Exercise5
{
	public class BankAccountEx5
	{
		private int accountNumber;
		private string accountHolder;
		private double _balance;
		public int AccountNumber { get; set; }
		public string AccountHolder { get; set; }
		public double Balance { get; set; }

		public BankAccountEx5(int accountNumber,string accountHolder,double balance)
		{
			this.AccountHolder = accountHolder;
			this.AccountNumber = accountNumber; 
            if (balance > 0)
			{
				_balance = balance;
				Balance = _balance;
            }
			else
			{
				throw new ArgumentException("Please note that the balance can't be negative; try again");
			}
			Bank.NumAccounts++;
        }

		public double Deposit (double amount)
		{
			if (amount>0)
			{
				return Balance += amount;
			}
			else
			{
                throw new ArgumentException("Please note that the amount can't be negative; try again");
            }
		}

		public double WithDraw(double amount)
		{
			if (Balance - amount < 0)
			{
                throw new ArgumentException("Please note that the Balance of the account will be negative; cannot proceed further on");
            }
			else
			{
                return Balance -= amount;
            }
		}

		public double GetInterest()
		{
            return Bank.CalculateInterest(Balance);
        }
	}
}

