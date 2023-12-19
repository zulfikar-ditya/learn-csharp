// See https://aka.ms/new-console-template for more information

namespace GetSet
{
    class GetSetProgram
    {
        static void Main(string[] args)
        {
            Movie movieInstance = new Movie("Avangers", ["action", "drama", "fantasy"], "PG-13");
            Movie movieInstance2 = new Movie("Tangled", ["romance", "factacy"], "asdads");
            
            Console.WriteLine(movieInstance.Rating);
            Console.WriteLine(movieInstance2.Rating);
        }   
    }
}

