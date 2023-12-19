namespace ClassCourse;

class MainClass
{
    static void Main(string[] args)
    {
        Book bookInstance = new Book();
        bookInstance.title = "Good Book";
        bookInstance.author = "Zulfikar";
        bookInstance.page = 150;
        
        Console.WriteLine("Book Title: " + bookInstance.title);
        Console.WriteLine("Book Author: " + bookInstance.author);
        Console.WriteLine("Book page: " + bookInstance.page);
        
        Console.ReadLine();
    }  
}
