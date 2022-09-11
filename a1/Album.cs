namespace A1
{
  class Album
  {
    private string album; 
    private string artist; 
    private int nTracks;
    private static Helper h = Helper.GetInstance();

    public Album()
    {
      // technically not needed, but good practice
      // would have been better to get the values from the user before making the object
      this.album = "No title";
      this.artist = "No artist";
      this.nTracks = 0;
    }

    public void Start()
    {
      // start the program
      Console.WriteLine("Starting the Album Program!");
      Console.WriteLine();
      ReadAndSaveAlbumData();
      DisplayAlbumInfo();
    }

    public void ReadAndSaveAlbumData()
    {
      // Read and save album's name
      this.SetAlbum(h.getString("What is the name of your favorite music album? "));
      // Read and save album's artist
      this.SetArtist(h.getString("What is the name of the Artist or Band for " + this.GetAlbum() + "? "));
      // Read and save album's number of tracks
      this.SetNTracks(int.Parse(h.getString("How many tracks does " + this.GetAlbum() + " have? ")));
    }

    public void DisplayAlbumInfo()
    {
      Console.WriteLine();
      Console.WriteLine("Album Name: " + this.GetAlbum());
      Console.WriteLine("Artist/Band: " + this.GetArtist());
      Console.WriteLine("Number of Tracks: " + this.GetNTracks());
      Console.WriteLine("Enjoy listening to " + this.GetAlbum() + " by " + this.GetArtist() + "!");
    }

    // setters
    public void SetAlbum(string album) { this.album = album; }
    public void SetArtist(string artist) { this.artist = artist; }
    public void SetNTracks(int nTracks) { this.nTracks = nTracks; }

    // getters
    public string GetAlbum() { return album; }
    public string GetArtist() { return artist; }
    public int GetNTracks() { return nTracks; }
  }
}
