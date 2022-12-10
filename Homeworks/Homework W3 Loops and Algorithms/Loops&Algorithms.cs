using System;
namespace Homework_W3_Loops_and_Algorithms
{
	
        public class loops
        {
            public void go()
            {
                Console.WriteLine("----EX 1---- ");


                int[] array = new int[] { 1, 2, 3, 4, 5, };

                int sum = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        sum += array[i];
                    }
                }
                Console.WriteLine("the total of the even given numbers is " + sum);
            }
        }
        public class ex1Alternative
        {
            public void go()
            {
                Console.WriteLine(" ex 1 modified");
                Console.WriteLine("Please insert the last number of your array, assume it starts from 1");
                int j = Convert.ToInt32(Console.ReadLine());
                j += 1;
                int[] array1 = new int[j];
                for (int i = 0; i < j; i++)
                {
                    array1[i] = i;

                }
                Console.WriteLine();
                int sum2 = 0;
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] % 2 == 0)
                    {
                        sum2 += array1[i];
                    }
                }
                Console.WriteLine(" the total of the even given  numbers is :" + sum2);
            }
        }

        public class exercise2
        {
            public void go()
            {
                Console.WriteLine("---Ex 2---");
                int[] array = new int[] { 1, 2, 3, 3, 4 };
                Array.Sort(array);
                List<int> list = new List<int>();
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] == array[i + 1])
                    {
                        list.Add(array[i]);
                        Console.WriteLine($"The item {array[i]} is already present in the array");
                    }
                }

            }

        }

        public class exercise3
        {
            public void go()
            {
                Console.WriteLine(" --- EX 3 ---");

                List<string> list = new List<string> { "a", "b", "b", "c", "c", "d", };

                List<string> results = new List<string> { };



                for (int i = 0; i < list.Count; i++)
                {
                    bool duplicate = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (list.ElementAt(i) == list.ElementAt(j))
                        {
                            duplicate = true;
                            break;
                        }
                    }
                    if (!duplicate)
                    {
                        results.Add(list[i]);
                    }


                }
                Console.Write("The list without duplicates : ");
                results.ForEach(Console.Write);

                Console.WriteLine();
            }
        }

        public class exercise4
        {
            public void go()
            {
                Console.WriteLine("--- EX 4 ---");
                int[] array = new int[] { 1, 4, 5, 2, 1, 4, 3, 1, 2 };
                int[] frequency = new int[array.Length];
                int visited = -1;
                for (int i = 0; i < array.Length; i++)
                {
                    int count = 1;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            count++;
                            frequency[j] = visited;
                        }
                    }
                    if (frequency[i] != visited)
                    {
                        frequency[i] = count;
                    }
                }

                for (int i = 0; i < frequency.Length; i++)
                {
                    if (frequency[i] != visited)
                    {
                        Console.WriteLine(" The element  " + array[i] + " has a frequence of " + frequency[i] + " times ");
                    }
                }
            }

        }

        public class exercise5
        {
            public void go()
            {

                Console.WriteLine(" --- EX 5----");
                Console.WriteLine("Please insert the number of elements of your array");
                int j = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[j];
                int[] even = new int[j];
                int[] odd = new int[j];
                int k = 0, m = 0;
                Console.WriteLine("Please insert the elements of your array : ");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());

                }
                for (int i = 0; i < j; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        even[k] = array[i];
                        k++;
                    }
                    else
                    {
                        odd[m] = array[i];
                        m++;
                    }
                }

                Console.WriteLine("The even numbers are : ");
                for (int i = 0; i < k; i++)
                {
                    Console.Write("{0} ", even[i]);

                }
                Console.WriteLine();

                Console.WriteLine("The odd numbers are : ");

                for (int i = 0; i < m; i++)
                {
                    Console.Write("{0} ", odd[i]);
                }
            }
        }
    public class AlgorithmInsertion
    {
        void Sort(int[] array)
        {
            int len = array.Length;

            for (int i = 1; i < len; ++i)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }

        }
        static void printArray(int[] array)
        {
            int len = array.Length;
            Console.WriteLine(" The sorted array is :");
            for (int i = 0; i < len; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
        public void Main()
        {
            Console.WriteLine(" Sorting Algorithm with Insertion method ");
            int[] array = new int[] { 3, 6, 1, 9, 53, 10, 2 };

            Console.WriteLine(" The input array is : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            AlgorithmInsertion ob = new AlgorithmInsertion();
            ob.Sort(array);
            printArray(array);

            Console.WriteLine("\n");
        }
    }

    public class AlgorithmQuicksort
    {
        static void swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;

        }
        static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);
            for (int j = low; j <= high - 1; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    swap(array, i, j);
                }


            }
            swap(array, i + 1, high);
            return (i + 1);

        }
        static void quickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);
                quickSort(array, low, pi - 1);
                quickSort(array, pi + 1, high);
            }
        }
        static void printArray(int[] array, int size)
        {
            for (int i = 0; i < size; i++)
            {

                Console.Write(array[i] + " ");
            }

        }

        public void Main()
        {
            Console.WriteLine(" Sorting Algorithm with Quicksort method");

            int[] array = new int[] { 3, 6, 1, 9, 53, 10, 2 };
            int n = array.Length;
            Console.WriteLine("input array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            quickSort(array, 0, n - 1);
            Console.WriteLine("Sorted array: ");
            printArray(array, n);
            Console.WriteLine();
        }
    }

    public class SearchAlgorithm
    {
        static int binarySearch(int[] array, int l, int r, int x)
        {
            if (r >= 1)
            {
                int mid = 1 + (r - 1) / 2;
                if (array[mid] == x)
                {
                    return mid;
                }
                if (array[mid] > x)
                {
                    return binarySearch(array, l, mid - 1, x);
                }
                else
                {
                    return binarySearch(array, mid + 1, r, x);
                }
            }
            return -1;
        }
        public void Main()
        {
            Console.WriteLine("\n");
            Console.WriteLine(" Binary Search ");
            int[] array = new int[] { 2, 4, 6, 8, 10, 14, 44, 54 };
            int n = array.Length;
            int x = 10;
            int result = binarySearch(array, 0, n - 1, x);
            if (result == -1)
            {
                Console.WriteLine("Element not present");
            }
            else
            {
                Console.WriteLine("Element found at index : " + result);
            }
        }
    }

}

