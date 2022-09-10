namespace A1
{
  class Album
  {

    private string name;
    private string artist;
    private int year;
    private int numSongs;
    private double price;
    private static Helper h = new Helper();

    public Album()
    {
      // technically not needed, but good practice
      // would have been better to get the values from the user before making the object
      this.name = "No title";
      this.artist = "No artist";
      this.year = 0;
      this.price = 0.0;
    }

    public void Start()
    {
      // start the program
      Console.WriteLine("Welcome to the Album Collection application!");
      Console.WriteLine();
      ReadAndSaveAlbumData();
      DisplayAlbumInfo();
    }

    public void ReadAndSaveAlbumData()
    {
      // Read and save album's name
      name = h.getString("What is the name of the album? ");
      this.SetName(name);

      // Read and save album's artist
      artist = h.getString("Who is the artist? ");
      this.SetArtist(artist);

      // Read and save album's year
      year = int.Parse(h.getString("What year was the album released? "));
      this.SetYear(year);

      // Read and save album's number of songs
      numSongs = int.Parse(h.getString("How many songs are on the album? "));
      this.SetNumSongs(numSongs);

      // Read and save album's price
      price = double.Parse(h.getString("What is the price of the album? "));
      this.SetPrice(price);
    }

    public void DisplayAlbumInfo()
    {
      string sep = "++++++++++++++++++++++++++++++++++++++++++++++";
      Console.WriteLine();
      Console.WriteLine(sep);
      Console.WriteLine("Name: " + this.GetName() + " Artist: " + this.GetArtist());
      Console.WriteLine("Year: " + this.GetYear() + " Number of songs: " + this.GetNumSongs());
      Console.WriteLine("Price: " + this.GetPrice());
      Console.WriteLine(sep);
    }

    // setters
    public void SetName(string name) { this.name = name; }
    public void SetArtist(string artist) { this.artist = artist; }
    public void SetYear(int year) { this.year = year; }
    public void SetNumSongs(int numSongs) { this.numSongs = numSongs; }
    public void SetPrice(double price) { this.price = price; }

    // getters
    public string GetName() { return name; }
    public string GetArtist() { return artist; }
    public int GetYear() { return year; }
    public int GetNumSongs() { return numSongs; }
    public double GetPrice() { return price; }
  }
}
