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

  public void Introduce(){}
  
  public void PredictTheDay(){}

  public void ReadName(){}

  public bool RunAgain(){
    return true;
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
