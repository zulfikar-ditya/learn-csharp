namespace GetSet;

public class Movie
{
    public string name;
    public string[] genres;
    private string rating;

    public Movie(string Aname, string[] Agenres, string Arating)
    {
        name = Aname;
        genres = Agenres;
        Rating = Arating;
    }

    public string Rating
    {
        get { return rating; }
        set
        {
            // search the rating from an array
            string[] ratings = ["G", "PG", "PG-13", "R", "NB"];
            foreach (var currentRating in ratings)
            {
                if (currentRating == value)
                {
                    rating = currentRating;
                    return;
                }
            }

            // if not found set to NR
            rating = "NR";
        }
    }
}