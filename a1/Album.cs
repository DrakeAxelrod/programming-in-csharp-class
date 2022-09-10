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
      Console.WriteLine("Welcome to the Album Collection application!");
      Console.WriteLine();
      ReadAndSaveAlbumData();
      DisplayAlbumInfo();
    }

    public void ReadAndSaveAlbumData()
    {
      // Read and save album's name
      this.SetAlbum(h.getString("Enter the album's name: "));
      // Read and save album's artist
      this.SetArtist(h.getString("Enter the album's artist: "));
      // Read and save album's number of tracks
      this.SetNTracks(int.Parse(h.getString("Enter the number of tracks on the album: ")));
    }

    public void DisplayAlbumInfo()
    {
      string sep = "++++++++++++++++++++++++++++++++++++++++++++++";
      Console.WriteLine();
      Console.WriteLine(sep);
      Console.WriteLine("Album: " + this.GetAlbum());
      Console.WriteLine("Artist: " + this.GetArtist());
      Console.WriteLine("Number of tracks: " + this.GetNTracks());
      Console.WriteLine(sep);
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
