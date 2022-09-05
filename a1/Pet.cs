namespace A1
{
  class Pet
  {
    private string name;
    private int age;
    private bool isFemale;

    public void Start()
    {
      Console.WriteLine();
      Console.WriteLine("Greetings from the Pet Owner application!");
      Console.WriteLine();

      ReadAndSavePetaData();
      DisplayPetInfo();
    }

    public void ReadAndSavePetaData()
    {

    }

    public void DisplayPetInfo()
    {

    }

    // setters
    public void SetName(string name) { this.name = name; }
    public void SetAge(int age) { this.age = age; }
    public void SetIsFemale(bool isFemale) { this.isFemale = isFemale }

    // getters
    public string GetName() { return name; }
    public int GetAge() { return age; }
    public bool GetIsFemale() { return isFemale; }

  }
}
