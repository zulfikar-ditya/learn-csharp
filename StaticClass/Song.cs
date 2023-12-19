namespace StaticClass;

public class Song
{
    public string title;

    public string artist;

    public int duration;

    public static int musicCount = 0;

    public Song(string aTitle, string aArtist, int aDuration)
    {
        title = aTitle;
        artist = aArtist;
        duration = aDuration;

        musicCount++;
    }
}