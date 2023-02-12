using System;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace GenericsAndAsync.Generics
{
	public class ApplyAction<T>
	{
        public List<T>? Mylist { get; set; } = new List<T>();

        public void ApplyLambdaAction ( Func<T,T> func)
        {
            foreach (var item in Mylist)
            {
                Console.WriteLine(func(item));
            }
        }

        public void ApplyTypeOfLambda(Func<T, Type> func)
        {
            foreach (var item in Mylist)
            {
                Console.WriteLine(func(item));
            }
        }
    }
}

