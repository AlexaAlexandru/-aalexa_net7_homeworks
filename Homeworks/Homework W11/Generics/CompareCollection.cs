using System;
using System.Runtime.CompilerServices;

namespace GenericsAndAsync.Generics
{
	public class CompareCollection : Icompare<List<string>>
	{
        public List<string> List1 { get; set; }
        public List<string> List2 { get; set; }

        public void Compare()
        {
            if (List1.Count()==List2.Count())
            {
                Console.WriteLine($"The two collections have the same size of {List1.Count()}");
            }
            else
            {
                Console.WriteLine("The two collections don't have the same size");
            }  
        }
    }
}

