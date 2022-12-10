// exercise 1

string input1 = Console.ReadLine();
int num1 = Convert.ToInt32(input1);
string input2 = Console.ReadLine();
int num2 = Convert.ToInt32(input2);
int addition = num1 + num2;
int substraction = num1 - num2;
int division = num1 / num2;
int multiplication = num1 * num2;

Console.WriteLine("Addition = " + addition + " ");
Console.WriteLine();
Console.WriteLine("Subtraction = " + substraction + " ");
Console.WriteLine();
Console.WriteLine("Division = " + division + " ");
Console.WriteLine();
Console.WriteLine("Multiplication = " + multiplication + " ");

string input3 = Console.ReadLine();
double num3 = Convert.ToDouble(input3);
string input4 = Console.ReadLine();
int num4 = Convert.ToInt32(input4);
double add = num3 + num4;
double sub = num3 - num4;
double div = num3 / num4;
double mult = num3 * num4;

Console.WriteLine("Addition = " + add + " ");
Console.WriteLine("Subtraction = " + sub + " ");
Console.WriteLine("Division = " + div + " ");
Console.WriteLine("Multiplication = " + mult + " ");

//Exercise 2

string input1 = Console.ReadLine();
int num1 = Convert.ToInt32(input1);
string input2 = Console.ReadLine();
int num2 = Convert.ToInt32(input2);
string input3 = Console.ReadLine();
int num3 = Convert.ToInt32(input3);

if (num1 < num2)
{
    if (num1 < num3)
    {
        Console.WriteLine("Minimum number is " + num1);
    }
    else
    {
        Console.WriteLine("Minimum number is " + num3);
    }
}
else
{
    if (num2 < num3)
    {
        Console.WriteLine("Minimum number is " + num2);
    }
    else
    {
        Console.WriteLine("Minimum number is " + num3);
    }
}

if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine("Maximum number is " + num1);
    }
    else
    {
        Console.WriteLine("Maximum number is " + num3);
    }
}
else
{
    if (num2 > num3)
    {
        Console.WriteLine("Maximum number is" + num2);
    }
    else
    {
        Console.WriteLine("Maximum number is " + num3);
    }
}

// Exercise 3
using System;

string input = Console.ReadLine();
int number = Convert.ToInt32(input);

int year, month, day;

year = number / 365;
month = (number - (year * 365)) / 30;
day = number - (year * 365) - (month * 30);

if (year == 1 && month == 1)
{
    Console.WriteLine(" 1 Year , 1 month , " + cday + "  days ");
}
else
{
    Console.WriteLine(year + "Years  ," + month + "  months" + day + "  days ");
}

// Exercise 4

string input1 = Console.ReadLine();
int num1 = Convert.ToInt32(input1);
string input2 = Console.ReadLine();
int num2 = Convert.ToInt32(input2);
string input3 = Console.ReadLine();
int num3 = Convert.ToInt32(input3);

int max, min;

min = (num1 < num2 && num1 < num3) ? num1 : (num2 < num3) ? num2 : (num3);
max = (num1 > num2 && num1 > num3) ? num1 : (num2 > num3) ? num2 : (num3);

Console.WriteLine(" Minumum number is: " + min);
Console.WriteLine(" Maximum number is: " + max);

// Exercise 5

Console.WriteLine("Enter the Physics mark: ");
string input1 = Console.ReadLine();
int phy = Convert.ToInt32(input1);
Console.WriteLine("Enter the Chemistry mark: ");
string input2 = Console.ReadLine();
int che = Convert.ToInt32(input2);
Console.WriteLine("Enter the Biology mark: ");
string input3 = Console.ReadLine();
int bio = Convert.ToInt32(input3);
Console.WriteLine("Enter the Mathematics mark: ");
string input4 = Console.ReadLine();
int mat = Convert.ToInt32(input4);
Console.WriteLine("Enter the Computer Science  mark: ");
string input5 = Console.ReadLine();
int comp = Convert.ToInt32(input5);

double percentage;
string grade;
percentage = (phy + che + bio + mat + comp) / 5;
grade = "grade";
if (percentage >= 90)
{
    grade = "A";
}

else if (percentage >= 80)
{
    grade = "B";
}
else if (percentage >= 70)
{
    grade = "C";
}
else if (percentage >= 60)
{
    grade = "D";
}
else if (percentage >= 40)
{
    grade = "E";
}
else if (percentage < 40)
{
    grade = "F";
}
Console.WriteLine(" Percentage = " + percentage + " and grade is " + grade);

//Exercise 6

char grades;
string notes;
Console.WriteLine("Insert your grade : ");
string input = Console.ReadLine();
grades = Convert.ToChar(input);
notes = ".";
switch (grades)
{
    case 'E':
        notes = "Excellent";
        break;
    case 'V':
        notes = "Very good";
        break;
    case 'G':
        notes = "Good";
        break;
    case 'A':
        notes = "Average";
        break;
    case 'F':
        notes = "Fail";
        break;
}

Console.WriteLine(notes);

//Exercise 7

int num;
string month;
Console.WriteLine("Insert your grade : ");
string input = Console.ReadLine();
num = Convert.ToInt32(input);
month = ".";
switch (num)
{
    case 1:
        month = "January";
        break;
    case 2:
        month = "February";
        break;
    case 3:
        month = "March";
        break;
    case 4:
        month = "April";
        break;
    case 5:
        month = "May";
        break;
    case 6:
        month = "June";
        break;
    case 7:
        month = "July";
        break;
    case 8:
        month = "August";
        break;
    case 9:
        month = "September";
        break;
    case 10:
        month = "Octomber";
        break;
    case 11:
        month = "November";
        break;
    case 12:
        month = "December";
        break;

}

Console.WriteLine(month);

//Exercise 8 

Console.WriteLine("Insert the temperature in centigrade ");
string input = Console.ReadLine();
double temp = Convert.ToDouble(input);
if (temp < 0.0)
{
    Console.WriteLine("Freezing weather");
}
else if (temp >= 0 && temp < 10)
{
    Console.WriteLine("Very Cold weather");
}
else if (temp >= 10 && temp < 20)
{
    Console.WriteLine("Cold weather");
}
else if (temp >= 20 && temp < 30)
{
    Console.WriteLine(" Normal in Temp");
}
else if (temp >= 30 && temp < 40)
{
    Console.WriteLine("Hot");
}
else
{
    Console.WriteLine("Very Hot");
}

// exercise 9

// + used when I sum something 
int a, b;
a = 1;
b = 4;
int sum = a + b;

// - used when i need a difference

int dif = a - b;
// * used when I need the product

int pro = a * b;
// / used when i need the division

double div = a / b;

// % used then i need the modulo 

double mod = a % b;

// ++ it increments its operand by 1.

int i = 5;
Console.WriteLine(i);
Console.WriteLine(i++);
Console.WriteLine(i);
// -- decrements its operand by 1. opposite of increment
// += it s an assignment operator and it adds the value of the right operand to the left one

int num1 = 3;
int num2 = 4;

num2 += num1; // it s going to be num2= num2 + num1 / 4+3 = 7

Console.WriteLine(num2);
// -= it s an assignment operator and it subtract the value of the right operand to the left one

num2 -= num1; // it s going to be num2= num2 - num1 / 4-3=1

Console.WriteLine(num2);