using System;
using System.Runtime.CompilerServices;

namespace GenericsAndAsync.Generics
{
	public  class ReverseOrder<T>
    {
        public List<T>? Mylist { get; set; }

        public void RunReverse()
        {
            Mylist.Reverse();

            foreach (var item in Mylist)
            {
                Console.WriteLine(item);
            }
        }
	}
}

