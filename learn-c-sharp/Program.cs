// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

string myFullName = "Zulfikar Ditya";
// char grade = "A";
int myAge = 19;
bool myGender = true;
double myHeight = 170.00;
float myWeight = 60;

Console.WriteLine("Hello My Full Name Is: " + myFullName);
Console.WriteLine("My Age is: " + myAge);
Console.WriteLine("I am a: " + (myGender ? "Make" : "Female"));
Console.WriteLine("My Height: " + myHeight);
Console.WriteLine("My Weight: " + myWeight );

int [] testArray = {1, 2, 3};

foreach (var test in testArray)
{
    Console.WriteLine(test);
}

TestFunction();

void TestFunction()
{
    Console.WriteLine("Hello From Test Function");
}

Console.WriteLine("result : " + SumNumber(testArray));

int SumNumber(int[] numbers)
{
    int result = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        result += numbers[i];
    }

    return result;
}

string GenderName = "";
if (myGender)
{
    GenderName = "Male";
}
else
{
    GenderName = "Female";
}

Console.WriteLine(GenderName);

int DayNum = 0;
string DayName = "";

switch (DayNum) 
{
    case 0:
        DayName = "Sunday";
        break;
    case 1:
        DayName = "Monday";
        break;
    default:
        DayName = "Invalid Input";
    break;
}

Console.WriteLine(DayName);


int sacredNumber = 10;
while (true)
{
    Console.WriteLine("Insert Sacred Number: ");
    
    int? input = Convert.ToInt16(Console.ReadLine());
    if (sacredNumber == input)
    {
        Console.WriteLine("Sacred Number Correct");
        Console.WriteLine("============");
        Console.WriteLine();
        break;
    }
    
    Console.WriteLine("============");
    Console.WriteLine("Invalid Sacred Number");
    continue;
}

int [,] multiArray =
{
    {
        1, 2, 3
    },
    {
        4, 5, 6
    }
};

int result = 0;
try
{
    int num1 = Convert.ToInt16(Console.ReadLine());
    int num2 = Convert.ToInt16(Console.ReadLine());

    result = num1 / num2;
}
catch (Exception e)
{
    Console.WriteLine(e);
    return;
}

Console.WriteLine(result);