using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using GenericsAndAsync.Async;
using GenericsAndAsync.Generics;

//Ex1();
//Ex2();
//Ex3();
await Ex4();
//Ex5();
//Ex6();
//Ex7();

void Ex1()
{
    var list1 = new ReverseOrder<int>();

    list1.Mylist = new List<int> { 1, 2, 3, 4, 5, 6 };

    list1.RunReverse();

    var list2 = new ReverseOrder<string>();

    list2.Mylist = new List<string> { "a", "b", "c", "d", "e" };

    list2.RunReverse();
}

void Ex2()
{
    var list1 = new ApplyAction<int>();

    list1.Mylist = new List<int> { 1, 2, 3, 5, 4, 6, 7 };

    list1.ApplyLambdaAction(x => x + 2);

    list1.ApplyTypeOfLambda(x => x.GetType());

    var list2 = new ApplyAction<string>();

    list2.Mylist = new List<string> { "a", "b", "c", "d", "e" };

    list2.ApplyLambdaAction(x => $"{x} alpha");
}

void Ex3()
{
    var queue1 = new CreateQueue<int>();
    queue1.Enqueue(1);
    queue1.Enqueue(2);
    queue1.Enqueue(3);
    queue1.Enqueue(4);
    queue1.Denqueue();
    queue1.Denqueue();
    queue1.Denqueue();
    queue1.Denqueue();
    queue1.Check();
    queue1.PrintQueue();

    var queue2 = new CreateQueue<string>();

    queue2.Check();
    queue2.Enqueue("Alex");
    queue2.Enqueue("Mircu");
    queue2.Enqueue("Dan");
    queue2.Denqueue();
    queue2.Enqueue("Liviu");
    queue2.PrintQueue();
}

async Task Ex4()
{
    var firstUrl = new FetchUrls();

    Stopwatch stopwatch = new Stopwatch();

    stopwatch.Start();

    await firstUrl.CallUrlsSequencellyAsync();

    stopwatch.Stop();

    Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);

    stopwatch.Reset();

    stopwatch.Start();

    await firstUrl.CallUrlsConcurrently();

    stopwatch.Stop();

    Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);

    await firstUrl.GetCatFacts();
}

void Ex5()
{
    var stringItems = new CompareStrings()
    {
        Input1 = "Hola",
        Input2 = "Ciao"
    };

    stringItems.Compare();

    var stringItems2 = new CompareStrings()
    {
        Input1 = "Hi",
        Input2 = "Bonjour"
    };

    stringItems2.Compare();

    var listCollection = new CompareCollection()
    {
        List1 = new List<string>() { "Hei", "Hola", "Ciao" },
        List2 = new List<string>() { "Bonjour", "Buna ziua", "Buongiorno" }
    };

    listCollection.Compare();

    var listCollection2 = new CompareCollection()
    {
        List1 = new List<string>() { "Hei", "Hola" },
        List2 = new List<string>() { "Bonjour", "Buna ziua", "Buongiorno" }
    };

    listCollection2.Compare();
}

void Ex6()
{
    String url = "https://cat-fact.herokuapp.com/facts";

    string s;

    using (HttpClient client = new HttpClient())
    {
        s = client.GetStringAsync(url).Result;
    }
    Console.WriteLine(s);
}

void Ex7()
{ 
    Task task = DocAsync.Main();
}

