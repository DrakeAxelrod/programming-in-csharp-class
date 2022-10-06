// See https://aka.ms/new-console-template for more information
internal class MainProgram
{
  public static void Main(String [] args)
  {
    Console.Title = "Strings, selection and iterations in C#";
    FunFeatures ff = new FunFeatures();
    MathWork mw = new MathWork();
    ff.Start();
    mw.Start();
    ContinueToNextPart();
  }

  private static void ContinueToNextPart()
  {
    Console.WriteLine("\nPRESS ENTER TO CONTINUE TO THE NEXT PART");
    Console.ReadLine();
    Console.Clear();
  }
}
