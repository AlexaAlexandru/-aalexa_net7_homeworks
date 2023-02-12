using System;
namespace GenericsAndAsync.Generics
{
	public class CompareStrings:Icompare<string>
	{
        public string Input1 { get; set; }
        public string Input2 { get; set; }

        public void Compare()
        {
            if (Input1.Length==Input2.Length)
            {
                Console.WriteLine($"The two items have the same length of {Input1.Length}");
            }
            else
            {
                Console.WriteLine("The two items don't have the same length");
            }
        }
    }
}

