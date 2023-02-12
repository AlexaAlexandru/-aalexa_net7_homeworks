using System;
namespace GenericsAndAsync.Async
{
	public class DocAsync
	{
		public static async Task Main()
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

			using (StreamWriter output = new StreamWriter(Path.Combine(path, "TextAsync.txt")))
			{
				await output.WriteAsync("This is my homework.");
			}
		}
	}
}

