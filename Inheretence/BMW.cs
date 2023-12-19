namespace Inheretence;

public class BMW: Car
{
    public BMW(string aName, string aTireCount, string aType)
    {
        MakeCar();
        name = aName;
        tireCount = aTireCount;
        type = aType;
    }
}