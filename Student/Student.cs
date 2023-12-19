namespace Student;

class Student
{
    public string FullName;

    public string Major;

    public double gpa;
    
    public Student(string AFullName, string AMajor, double aGpa)
    {
        FullName = AFullName;
        Major = AMajor;
        gpa = aGpa;
    }

    public bool HasReward()
    {
        if (gpa >= 3.5)
        {
            return true;
        }

        return false;
    }
}