using System;
namespace Homeworks_W7.Exercise5
{
	public static class DateTimeExtensions
	{
		public static string ToFullDateString (this DateTime d)
		{
			var output = $"{d.Month}/{d.Day}/{d.Year} {d.Hour} : {d.Minute} : {d.Second}";
			return output;
		}
    }
}

