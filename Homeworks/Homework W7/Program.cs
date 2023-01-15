using System;
using System.Data.Common;
using System.IO;
using System.Linq;
using Homeworks_W7.Exercise1;
using Homeworks_W7.Exercise10;
using Homeworks_W7.Exercise2;
using Homeworks_W7.Exercise5;
using Homeworks_W7.Exercise6;
using Homeworks_W7.Exercise9;

//RunEx1();
//RunEx2();
//RunEx3();
//RunEx4();
RunEx5();
//RunEx6();
//RunEx7();
//RunEx8();
//RunEx9();
//RunEx10();
//RunEx11();

void RunEx1()
{
    Console.WriteLine("Insert the date: ");

    DateTime time = Convert.ToDateTime(Console.ReadLine());

    if (time > DateTime.Today)
    {
        throw new InvalidDateException("Please note that the data inserted is in the future");
    }
}

void RunEx2()
{
    List<string> names = new List<string>();

    Console.WriteLine("how many names do you want to add ? ");

    int input = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < input; i++)
    {
        Console.WriteLine(" Please insert the name ");
        string inputName = Console.ReadLine();
        if (inputName == string.Empty)
        {
            throw new BlankNameException("Please note that you didn't provide a name");
        }
        names.Add(inputName);
    }

}

void RunEx3()
{
    Console.WriteLine("Insert list of numbers separated by space");
    string inputNumbers = Console.ReadLine();

    List<string> listNumbers = inputNumbers?.Split().ToList();
    var sum = 0;
    var n = 0;
    try
    {
        foreach (var item in listNumbers)
        {
            sum += Convert.ToInt32(item);
            n++;
        }
        var average = sum / n;

        Console.WriteLine($"The sum is {sum}, and the average : {average}");
    }

    catch (FormatException format)
    {
        throw (format);
    }

    catch (OverflowException flow)
    {
        throw (flow);
    }

    catch (DivideByZeroException divide)
    {
        throw (divide);
    }

}

void RunEx4()
{

    try
    {
        var currentWorkingDirectory = Directory.GetCurrentDirectory() + "demo.txt";

        var path = @"/Users/alexandrualexa/Documents/NET/myownAlex/Homeworks copy/Homeworks W7  Exceptions -LINQ, Lambdas/demo.txt";

        string text = File.ReadAllText(path);

        if (text.Length == 0)
        {
            Console.WriteLine("Please note the file is empty, add some) text :");
            var input = Console.ReadLine();
            File.WriteAllText(path, input);
        }

        Console.WriteLine(text);
    }

    catch (FileNotFoundException ex)
    {
        var path = Directory.GetCurrentDirectory();
        string fileName = System.IO.Path.GetRandomFileName();
        Console.WriteLine("Add some words to the new file :");
        var input = Console.ReadLine();
        File.WriteAllText(path, input);
    }

    catch (IOException exception)
    {
        Console.WriteLine(exception.Message);
        Console.WriteLine("error while reading or writing the file");
    }

}

void RunEx5()
{
    DateTime date = DateTime.Now;
    Console.WriteLine(date.ToFullDateString());

}

void RunEx6()
{
    int n = 8;
    Console.WriteLine(n.NumberToBinary());
}

void RunEx7()
{
    List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    var sum = list.Where(l => l % 2 == 0)
        .Sum(l => Math.Pow(l, 2));

    Console.WriteLine(sum);
}

void RunEx8()
{
    List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    var newlist = list.Select(l => l * l).ToList();

    foreach (var item in newlist)
    {
        Console.WriteLine(item);
    }

}

void RunEx9()
{
    var students = new List<Student>
    {
        new Student { Name = "Alice", Grade = "A" },
        new Student { Name = "Bob", Grade = "B" },
        new Student { Name = "Charlie", Grade = "A" },
        new Student { Name = "Dave", Grade = "C" }
    };

    var descendingOrder = students.FindAll(s => s.Grade == "A")
                                    .OrderByDescending(s => s.Name);

    foreach (var item in descendingOrder)
    {
        Console.WriteLine(item.Name);
    }
}

void RunEx10()
{
    var products = new List<Product>
    {
        new Product { Name = "Product 1", Category = "Category 1", Price = 10 },
        new Product { Name = "Product 2", Category = "Category 2", Price = 20 },
        new Product { Name = "Product 3", Category = "Category 1", Price = 15 },
        new Product { Name = "Product 4", Category = "Category 3", Price = 5 },
        new Product { Name = "Product 5", Category = "Category 3", Price = 5 }
    };

    var newlist = products.DistinctBy(p => p.Category)
                            .OrderBy(p => p.Price)
                            .OrderBy(p => p.Name)
                            .ToList();

    foreach (var item in newlist)
    {
        Console.WriteLine($"the product {item.Name} from category {item.Category} has the price : {item.Price}");
    }
}

void RunEx11()
{
    var products = new List<Product>
    {
        new Product { Name = "Product 1", Category = "Category 1", Price = 10 },
        new Product { Name = "Product 2", Category = "Category 2", Price = 20 },
        new Product { Name = "Product 3", Category = "Category 1", Price = 15 },
        new Product { Name = "Product 4", Category = "Category 3", Price = 5 },
        new Product { Name = "Product 5", Category = "Category 3", Price = 5 }
    };

    var list = products.GroupBy(p => p.Category)
                        .OrderByDescending(p => p.Key)
                        .Select(p => new
                        {
                            Key = p.Key,
                            Price = p.Average(a => a.Price)
                        });

    foreach (var item in list)
    {
        Console.WriteLine($"From category {item.Key} the average price is {item.Price}");
    }

}
