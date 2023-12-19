namespace Student
{
    class StudentProgram
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Student 1", "Software Engineer", 3.8);
            Student student2 = new Student("Student 2", "Art", 3.0);
            
            Console.WriteLine("The student with name: " + student1.FullName + (student1.HasReward() ? " honor some reward." : " doesn't honor reward."));
            Console.WriteLine("The student with name: " + student2.FullName + (student2.HasReward() ? " honor some reward." : " doesn't honor reward."));
        }
    }
}

