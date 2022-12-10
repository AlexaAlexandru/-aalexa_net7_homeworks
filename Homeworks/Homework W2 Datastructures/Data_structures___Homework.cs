using System;
namespace Homework_W2_Datastructures
{
    public class DataStructuresH
    {
        public void Go()
        {
            //Point 2

            Console.WriteLine("-----Point 2-----");

            int[,] matrix = new int[4, 3];
            matrix[0, 0] = 123;
            matrix[0, 1] = 345;
            matrix[0, 2] = 567;
            matrix[1, 0] = 12;
            matrix[1, 1] = 56;
            matrix[1, 2] = -12;
            matrix[2, 0] = 34;
            matrix[2, 1] = -98;
            matrix[2, 2] = 65;
            matrix[3, 0] = 765;
            matrix[3, 1] = 543;
            matrix[3, 2] = 321;

            Console.WriteLine(matrix[1, 1] + " and " + matrix[2, 1]);

            //Point 3
            Console.WriteLine("-----Point 3-----");

            List<string> list1 = new List<string>(4);
            list1.Add("Alex");
            list1.Add("Lore");

            Console.WriteLine("Insert a name");

            string input1 = Console.ReadLine();

            if (list1.Contains(input1))
            {
                Console.WriteLine($" The name {input1} is already present in the list");

            }
            else
            {
                list1.Add(input1);
                Console.WriteLine("The name " + input1 + " was added into the list");

                Console.WriteLine($"The list is the following {list1[0]} , {list1[1]} , {list1[2]}");
            }

            //Point 4

            Console.WriteLine("-----Point 4-----");

            Stack<int> stack = new Stack<int>();

            Console.WriteLine("Please insert first integer number");
            string inp = Console.ReadLine();
            int num1 = Convert.ToInt32(inp);
            Console.WriteLine("Please insert second integer number");
            string inp1 = Console.ReadLine();
            int num2 = Convert.ToInt32(inp1);

            stack.Push(num1);
            stack.Push(num2);

            int x = stack.ElementAt(0);
            int y = stack.ElementAt(1);
            int z = x + y;
            if (x == 30 || y == 30 || z == 30)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            // Point 5

            Console.WriteLine("-----Point 5-----");

            Queue<int> e = new Queue<int>(5);

            string inp3 = Console.ReadLine();
            int q1 = Convert.ToInt32(inp3);
            string inp4 = Console.ReadLine();
            int q2 = Convert.ToInt32(inp4);
            string inp5 = Console.ReadLine();
            int q3 = Convert.ToInt32(inp5);
            string inp6 = Console.ReadLine();
            int q4 = Convert.ToInt32(inp6);
            string inp7 = Console.ReadLine();
            int q5 = Convert.ToInt32(inp7);

            e.Enqueue(q1);
            e.Enqueue(q2);
            e.Enqueue(q3);
            e.Enqueue(q4);
            e.Enqueue(q5);

            int a = e.ElementAt(0);
            int rest = a % 3;
            int rest2 = a % 7;
            bool condition1 = (a >= 0 && rest == 0);
            bool condition2 = (a >= 0 && rest == 0);

            if (condition1 || condition2)
            {
                Console.WriteLine("Checked");
            }
            else
            {
                e.Dequeue();
                Console.WriteLine($"The new top of the queue is : {e.ElementAt(0)}");
            }
        }
    }
}


