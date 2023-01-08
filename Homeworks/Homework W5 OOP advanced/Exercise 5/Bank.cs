using System;
namespace Homework_W5_OOP_advanced.Exercise5
{
	public static class Bank
	{
		public static double InterestRate { get; set; } = 0.01;
		public static int NumAccounts { get; set; } = 0;

		public static double CalculateInterest(double Balance)
		{
            return Balance * InterestRate;
        }

		public static int GetNumAccounts()
		{
            return NumAccounts;
        }

		public static double IncrementInterest()
		{
           return InterestRate += 0.01;
        }
	}
}

