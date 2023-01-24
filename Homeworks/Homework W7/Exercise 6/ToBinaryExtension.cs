using System;
namespace Homeworks_W7.Exercise6
{
	public static class ToBinaryExtension
	{
		public static string NumberToBinary ( this int n )
		{
			var binary = Convert.ToString(n, 2);
			return binary;
		}
    }
}

