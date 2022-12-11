using Homework_W4_OOP_Exercises;

Console.WriteLine("------EX 1 -------");

Book book = new Book("War and Peace","Lev Tolstoy",1869);

Console.WriteLine(book.GetTitle());
Console.WriteLine(book.GetAuthor());
Console.WriteLine(book.GetYear());

book.SetTitle("Anna Karenina");
book.SetAuthor("Lev Tolstoy");
book.SetYear(1877);

Console.WriteLine(book.GetTitle());
Console.WriteLine(book.GetAuthor());
Console.WriteLine(book.GetYear());

Console.WriteLine();

Console.WriteLine("------EX 2 -------");

Product product = new Product("Apple",0.99,10);

Console.WriteLine(product.GetName());
Console.WriteLine(product.GetPrice());
Console.WriteLine(product.GetQuantity());

product.SetName("Orange");
product.SetPrice(1.49);
product.SetQuantity(20);

Console.WriteLine(product.GetName());
Console.WriteLine(product.GetPrice());
Console.WriteLine(product.GetQuantity());
Console.WriteLine();

Console.WriteLine("------EX 3 -------");

Animal animal = new Animal("Max", "Dog", "Labrador Retriever", 2, "yellow", 75, true);

Console.WriteLine(animal.GetName());
Console.WriteLine(animal.GetSpecies());
Console.WriteLine(animal.GetBreed());
Console.WriteLine(animal.GetAge());
Console.WriteLine(animal.GetColor());
Console.WriteLine(animal.GetWeight());
Console.WriteLine(animal.IsSpayedOrNeutered());

animal.SetName("Buddy");
animal.SetSpecies("Cat");
animal.SetBreed("Siamese");
animal.SetAge(5);
animal.SetColor("Gray");
animal.SetWeight(12);
animal.SetIsSpayedOrNeutered(false);

Console.WriteLine(animal.GetName());
Console.WriteLine(animal.GetSpecies());
Console.WriteLine(animal.GetBreed());
Console.WriteLine(animal.GetAge());
Console.WriteLine(animal.GetColor());
Console.WriteLine(animal.GetWeight());
Console.WriteLine(animal.IsSpayedOrNeutered());
Console.WriteLine();

Console.WriteLine("------EX 4 -------");

Calculator calculator = new Calculator();

Console.WriteLine(calculator.Add(2,3));
Console.WriteLine(calculator.Substract(5,2));
Console.WriteLine(calculator.Multiply(3,4));
Console.WriteLine(calculator.Divide(10,5));
Console.WriteLine(calculator.Power(2,3));
Console.WriteLine(calculator.SquareRoot(9));
Console.WriteLine();

Console.WriteLine("------EX 5 -------");

University myUnniversity = new University("My university");

Student john = new Student("John", "Doe", 123456, 3.8);
Student jane = new Student("Jane", "Smith", 6554321, 3.6);

myUnniversity.AddStudent(john);
myUnniversity.AddStudent(jane);

Console.WriteLine(myUnniversity.GetStudentCount());



