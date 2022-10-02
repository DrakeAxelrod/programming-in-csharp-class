
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
  }

  public void Introduce(){
    DateTime dt = DateTime.Now;
    Console.WriteLine("My name is: Drake and I am a student of {0}-{1}-{2} semester", dt.Year, dt.Month, dt.Day);
    Console.WriteLine("Tell me some basic information about yourself");
    // no newline
    Console.Write("Your first name please: ");
    // Capitalize first letter
    string fname = Console.ReadLine().ToLower();
    fname = fname.Substring(0, 1).ToUpper() + fname.Substring(1);
    char.ToUpper(fname[0]);
    Console.Write("Your last name please: ");
    string lname = Console.ReadLine().ToUpper();
    Console.WriteLine("Nice to meet you {0}!", fname);
    Console.Write("Give me your email please: ");
    string email = Console.ReadLine();
    Console.WriteLine("Here is your full name and your email.");
    Console.WriteLine("{0}, {1}  {2}", lname, fname, email);
  }
  
  public void PredictTheDay(){}

  public void ReadName(){}

  public bool RunAgain(){
    Console.WriteLine("Do you want to run the program again? (y/n)");
    string ans = Console.ReadLine().ToLower();
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
