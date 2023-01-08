using System;
namespace Homework_W4_OOP_Exercises
{
	public class Calculator
	{
	
		public int Add( int x, int y )
		{
			int sum = x + y;
			return sum;
		}

		public int Substract( int x, int y)  
		{
			int sub = x - y;

			return sub;
		}

		public int  Multiply( int x, int y )
		{
			int mult = x * y;

			return mult;
		}

		public int Divide( int x,int y )
		{
			int div = x / y;

			return div;
		}

		public double Power( int x, int y )
		{
			double pow = Math.Pow(x,y);

			return pow;
		}

		public double SquareRoot( int x )

		{
			double sq = Math.Sqrt(x);
			return sq;
		}

	}

}

