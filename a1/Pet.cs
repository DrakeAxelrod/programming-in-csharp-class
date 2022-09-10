namespace A1
{
  class Pet
  {
    private static Helper h = new Helper();
    private string name;
    private int age;
    private bool isFemale;

    public Pet()
    {
      // technically not needed, but good practice
      // would have been better to get the values from the user before making the object
      name = "No name";
      age = 0;
      isFemale = true;
    }

    public void Start()
    {
      h.SpacedText("Greetings from the Pet Owner application!");
      ReadAndSavePetData();
      DisplayPetInfo();
    }

    public void ReadAndSavePetData()
    {
      // Read and save pet's name
      this.SetName(h.getString("What is the name of your pet? "));
      // Read and save pet's age
      this.SetAge(int.Parse(h.getString("What is " + name + "'s age? ")));
      // Read and save pet's gender (y or n)
      char res = h.getString("Is your pet female? (y/n) ").Trim().ToLower()[0];
      this.SetIsFemale(res == 'y' ? true : false);
    }

    public void DisplayPetInfo()
    {
      string sep = "++++++++++++++++++++++++++++++++++++++++++++++";
      Console.WriteLine();
      Console.WriteLine(sep);
      Console.WriteLine("Name: " + this.GetName() + " Age: " + this.GetAge());
      Console.WriteLine(this.name + " is a good " + (this.GetIsFemale() ? "girl" : "boy") + "!");
      Console.WriteLine(sep);
    }

    // setters
    public void SetName(string name) { this.name = name; }
    public void SetAge(int age) { this.age = age; }
    public void SetIsFemale(bool isFemale) { this.isFemale = isFemale; }

    // getters
    public string GetName() { return name; }
    public int GetAge() { return age; }
    public bool GetIsFemale() { return isFemale; }

  }
}
