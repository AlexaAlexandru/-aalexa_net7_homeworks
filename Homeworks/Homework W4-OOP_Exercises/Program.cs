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

List<string> maryFaculties = new List<string>() { "Math", "Physics" };
List<string> bobFaculties = new List<string>() { "English", "History" };

Faculty mary = new Faculty("mary", "Jones", 111111,maryFaculties);
Faculty bob = new Faculty("bob", "Smith", 222222, bobFaculties);

Console.WriteLine(myUnniversity.GetStudentCount());

myUnniversity.AddFaculties(mary);
myUnniversity.AddFaculties(bob);

Console.WriteLine(myUnniversity.GetFacultiesCount());

Console.WriteLine();

Console.WriteLine("------Ex 6 and 7 -------");

College college = new College();
college.name = "UMF Grigore T.Popa";

College college1 = new College();
college1.name = "Universitatea Alexandru Ioan Cuza";

StudentEx6 student1 = new StudentEx6("Alex", DateTime.Now.AddYears(-5), DateTime.Now.AddYears(-1),college, DateTime.Now.AddYears(-25));

Console.WriteLine(student1.IsStillStudent());
Console.WriteLine(student1.GetAge());

student1.Print();


Professor prof = new Professor("Ionescu Nelu", college1, "Topografie");

prof.Print();
prof.AddStudent(student1);








