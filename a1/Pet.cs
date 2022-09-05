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
      // Read and save pet's name
      Console.Write("Enter the pet's name: ");
      name = Console.ReadLine();
      this.SetName(name);

      // Read and save pet's age
      Console.Write("Enter the pet's age: ");
      age = int.Parse(Console.ReadLine());
      this.SetAge(age);

      // Read and save pet's gender (y or n)
      Console.Write("Is your pet female? (y/n) ");
      char res = Console.Readline().Trim().ToLower()[0];
      res == 'y' ? this.SetIsFemale(true) : this.SetIsFemale(false);
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
