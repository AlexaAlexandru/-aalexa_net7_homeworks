using System;
namespace GenericsAndAsync.Generics
{
	public class CreateQueue<T>
	{
        public List<T>? Queue { get; set; } = new List<T>();

		public void Enqueue(T item)
        {
            Queue.Add(item);
        }

        public void Denqueue()
        {
            Queue.RemoveAt(0);
        }

        public void Pick()
        {
            Queue.ElementAt(0);
        }

        public Boolean Check()
        {
            if (Queue.Count()==0)
            {
                var result = "the queue is empty";
                Console.WriteLine(result);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintQueue()
        {
            foreach (var item in Queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}



