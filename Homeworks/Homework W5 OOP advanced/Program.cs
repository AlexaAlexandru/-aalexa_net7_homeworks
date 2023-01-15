using System;
using Homework_W5_OOP_advanced;
using Homework_W5_OOP_advanced.Exercise1;
using Homework_W5_OOP_advanced.Exercise2;
using Homework_W5_OOP_advanced.Exercise3;
using Homework_W5_OOP_advanced.Exercise4;
using Homework_W5_OOP_advanced.Exercise5;
using Homework_W5_OOP_advanced.Exercise6;
using Homework_W5_OOP_advanced.Exercise7;

//RunExercise1();

//RunExercise2();

//RunExercise3();

//RunExercise4();

//RunExercise5();

//RunExercise6();

//RunExercise7();

//HotelMain.Run();

void RunExercise1()
{
    Console.WriteLine("----Ex 1----");

    var myAccount = new BankAccount(123456, "John Doe", 1000);

    myAccount.Deposit(500);
    myAccount.Withdraw(200);

    Console.WriteLine(myAccount.GetBalance());

    List<Transaction> transactions = myAccount.GetTransactionHistory();
    foreach (Transaction transaction in transactions)
    {
        Console.WriteLine($"{transaction.Timestamp}: {transaction.Type} ${transaction.Amount}");
    }

    myAccount.AccountNumber = 654321;
    myAccount.AccountHolder = "Jane Smith";

    Console.WriteLine(myAccount.AccountNumber);
    Console.WriteLine(myAccount.AccountHolder);
}

void RunExercise2()
{
    Console.WriteLine("----Ex 2----");

    Book book = new Book("The Great Gatsby", "F.Scott Fitzgerald", 180);

    Console.WriteLine(book.GetTitle());
    Console.WriteLine(book.GetAuthor());
    Console.WriteLine(book.GetPageCount());
    Console.WriteLine(book.GetCurrentPage());

    book.NextPage();
    Console.WriteLine(book.GetCurrentPage());

    book.NextPage();
    book.NextPage();
    book.NextPage();
    Console.WriteLine(book.GetCurrentPage());

    book.PreviousPage();
    Console.WriteLine(book.GetCurrentPage());

    book.Title = "The Great Gatsby (Revised Edition)";
    Console.WriteLine(book.GetTitle());
    book.Author = "F. Scott Fitzgerald (Revised by Jane Doe)";
    Console.WriteLine(book.GetAuthor());
}

void RunExercise3()
{
    Console.WriteLine("----Ex 3----");

    Rectangle rectangle1 = new Rectangle("Green", 6, 8);
    Rectangle rectangle2 = new Rectangle("Yellow", 10, 12);

    Circle circle1 = new Circle("Purple", 3);
    Circle circle2 = new Circle("Orange", 5);

    List<Shape> shapes = new List<Shape> { rectangle1, rectangle2, circle1, circle2 };

    foreach (Shape shape in shapes)
    {
        shape.CalculateArea();
    }

    shapes.Sort((shape1, shape2) => shape2.Area.CompareTo(shape1.Area));

    foreach (Shape shape in shapes)
    {
        Console.WriteLine(shape.Color + ": " + shape.Area);
    }

    double totalPerimeter = 0;
    foreach (Shape shape in shapes)
    {
        totalPerimeter += shape.GetPerimeter();
    }

    Console.WriteLine("Total perimeter: " + totalPerimeter + " inches");
}

void RunExercise4()
{
    Console.WriteLine("----Ex 4----");

    Manager manager = new Manager("John Doe", 35, 50_000, Department.IT);
    Developer developer = new Developer("Jane Smith", 28, 30_000, new List<string> { "C#", "Javascript" }, false);

    Console.WriteLine(manager.CalculateBonus());
    Console.WriteLine(developer.CalculateBonus());

    Console.WriteLine(manager.GetContactInfo());
    Console.WriteLine(developer.GetContactInfo());

    //Console.WriteLine(developer.GetContactInfo());
}

void RunExercise5()
{
    Console.WriteLine("----Ex 5----");

    BankAccountEx5 account1 = new BankAccountEx5(123456, "John Doe", 1000);
    BankAccountEx5 account2 = new BankAccountEx5(654321, "Jane Smith", 2000);

    account1.Deposit(500);
    account2.WithDraw(1000);

    Console.WriteLine(account1.Balance);
    Console.WriteLine(account2.Balance);

    Console.WriteLine(account1.GetInterest());
    Console.WriteLine(account2.GetInterest());

    Console.WriteLine(Bank.NumAccounts);
}

void RunExercise6()
{
    Console.WriteLine("----Ex 6----");

    IShape circle = new CircleEx6(5);
    IShape rectangle = new RectangleEx6(10, 5);

    Console.WriteLine(circle.CalculateArea());
    Console.WriteLine(rectangle.CalculateArea());

    Console.WriteLine(circle.CalculateArea("Square feet"));
    Console.WriteLine(rectangle.CalculateArea("Square meters"));

    Icolor circleColor = (Icolor)circle;
    circleColor.Color = "Red";

    Icolor rectangleColor = (Icolor)rectangle;
    rectangleColor.Color = "Blue";

    Console.WriteLine(circleColor.Color);
    Console.WriteLine(rectangleColor.Color);
}

void RunExercise7Testing()
{
    Console.WriteLine("----Ex 7----");

    Hotel hotel = new Hotel()
    {
        HotelName = "hotel 1",
        Location = "Iasi",
        PostalCode = 700932,
    };

    Console.WriteLine(hotel.ToString());
    Console.WriteLine($"{hotel.HotelName} , in {hotel.Location} {hotel.PostalCode}");

    hotel.AddSingleRoom(1, 1);
    hotel.AddSingleRoom(2, 1);
    hotel.AddDoubleRoom(3, 2);
    hotel.AddLuxuryRoom(4, 3);

    Console.WriteLine(hotel.Rooms.First().RoomType());
    hotel.ShowAllRooms();
    hotel.GetAvailableRooms(DateTime.Now, DateTime.Now.AddDays(2));

    hotel.RegisterClient("2900101227952", "Gigi", "Necula", "gigi@necula.com", "07221210111");
    hotel.RegisterClient("2900101221212", "Giovani", "Hargs", "giovaniecula@gmail.com", "07221210111");
    hotel.RegisterClient("2900101344112", "Alex", "Liviu", "alexliviu@gmail.com", "072234210111");

    hotel.ShowAllClients();

    hotel.AddBooking("2900101227952", 1, DateTime.Today, DateTime.Today.AddDays(2));
    hotel.AddBooking("2900101344112", 2, DateTime.Today.AddDays(-5), DateTime.Today.AddDays(-2));

    hotel.AllBookings();
    hotel.ActiveBooking();

    hotel.RemoveClient("2900101221212");
    hotel.ShowAllClients();

    hotel.GetAvailableRooms(DateTime.Now, DateTime.Now.AddDays(2));

    hotel.UpdteRoomPrice(1, 60.2);
    hotel.ShowAllRooms();

    hotel.AddLuxuryRoom(5, 3);
    hotel.RegisterClient("7621022201344112", "Luca", "Bonariu", "luca@ss.com", "0729421123");
    hotel.AddBooking("7621022201344112", 3, DateTime.Today, DateTime.Today.AddDays(4));

    hotel.ShowAllRooms();
    Console.WriteLine("--");
    hotel.ShowAllClients();
    Console.WriteLine("--");
    hotel.GetAvailableRooms(DateTime.Now, DateTime.Now.AddDays(2));

    Console.WriteLine("Changes on client list and availabity room ");

    hotel.ClearBookingId("7621022201344112");
    hotel.GetAvailableRooms(DateTime.Now, DateTime.Now.AddDays(2));

    hotel.ActiveBooking();


    HotelMain.ShowAvailableRooms(hotel);

    
}

HotelMain.Run();

//HotelMain2.Run();






