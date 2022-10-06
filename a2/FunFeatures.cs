
class FunFeatures
{
  private string name = "";
  // private string email = "";

  public FunFeatures()
  {
    this.name = "";
    // this.email = "";
  }

  public void CalculateStrengthLength()
  {
    Console.WriteLine();
    Console.WriteLine("Length of text: Write a text with any number of characters and press Enter I will then calculate the number of chars included in the text");
    Console.WriteLine("Give me a text of any length, or press Enter to exit");
    string text = Console.ReadLine() ?? "";
    Console.WriteLine();
    Console.WriteLine(text.ToUpper());
    Console.WriteLine("number of chars = {0}", text.Length);
    Console.WriteLine();
  }

  public void Introduce(){
    DateTime dt = DateTime.Now;
    Console.WriteLine("My name is: Drake and I am a student of {0}-{1}-{2} semester", dt.Year, dt.Month, dt.Day);
    Console.WriteLine();
    Console.WriteLine("Tell me some basic information about yourself");
    string fname = this.ReadName("Your first name please: ");
    fname = fname.Substring(0, 1).ToUpper() + fname.Substring(1);
    char.ToUpper(fname[0]);
    string lname =  this.ReadName("Your last name please: ").ToUpper();
    Console.WriteLine("Nice to meet you {0}!", fname);
    Console.Write("Give me your email please: ");
    string email = Console.ReadLine() ?? "";
    Console.WriteLine();
    Console.WriteLine("Here is your full name and your email.");
    this.name = lname + ", " + fname;
    Console.WriteLine("{0}, {1}  {2}", lname, fname, email);
  }
  
  public void PredictTheDay(){
    // hash table
    String[] phrases = {
    "Monday: Keep calm my friend! You can fall apart!",
    "Tuesday and Wednesday break your heart!",
    "Thursday, OMG, still one day to Friday!",
    "It's Friday! You are in love!",
    "Saturday, do nothing and do plenty of it!",
    "And Sunday always comes too soon!",
    "Not in a good mode? This is not a valid date!"
    };
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("I am a fortune teller.");
    int ans = 0;
    do {
      Console.WriteLine("Select a number between 1 and 7: ");
      ans = Convert.ToInt32(Console.ReadLine());
      switch (ans) {
        case 1:
          Console.WriteLine(phrases[0]);
          break;
        case 2:
          Console.WriteLine(phrases[1]);
          break;
        case 3:
          Console.WriteLine(phrases[2]);
          break;
        case 4:
          Console.WriteLine(phrases[3]);
          break;
        case 5:
          Console.WriteLine(phrases[4]);
          break;
        case 6:
          Console.WriteLine(phrases[5]);
          break;
        case 7:
          Console.WriteLine(phrases[6]);
          break;
        default:
          Console.WriteLine("The number is not valid! try again!");
          break;
      }
    } while (ans < 1 || ans > 7);
  }

  public String ReadName(String s) {
    Console.WriteLine(s);
    String ans = Console.ReadLine().ToLower() ?? "";
    return ans;
  }

  public bool RunAgain(){
    Console.WriteLine("Do you want to run the program again? (y/n)");
    string ans = Console.ReadLine().ToLower() ?? "";
    Console.WriteLine(ans);
    // ternary operator
    return ans == "y" || ans  == "yes" ? true : false;
  }

  public void Start(){
    Introduce();

    bool done = false;
    do
    {
      PredictTheDay();
      CalculateStrengthLength();
      done = RunAgain();
    } while (!done);
    Console.WriteLine("Welcome Back, {0}", this.name);
  }
}
