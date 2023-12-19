namespace Inheretence;

public class Car
{
    public string name;
    public string tireCount;
    public string type;
    
    public static void MakeCar()
    {
        Console.WriteLine("Making your car");
        Console.WriteLine("======================");
    }

    public void PrintCar()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("TireCount: " + tireCount);
        Console.WriteLine("Type: " + type);
    }
}