namespace StaticClass
{
    class StaticClassProgram
    {
        public static void Main(string[] args)
        {
            Song songOne = new Song("Star Walking", "Lil Nas Z", 200);
            Console.WriteLine(Song.musicCount);
            Song songTwo = new Song("Maps", "Maroon 5", 200);
            Console.WriteLine(Song.musicCount);
        }   
    }
}

