// See https://aka.ms/new-console-template for more information
internal class MainProgram
{
  public static void Main(String [] args)
  {
    Console.Title = "Strings, selection and iterations in C#";
    FunFeatures ff = new FunFeatures();
    MathWork mw = new MathWork();
    TemperatureConverter tc = new TemperatureConverter();
    WorkingSchedule ws = new WorkingSchedule();
    ff.Start();
    ContinueToNextPart();
    mw.Start();
    ContinueToNextPart();
    tc.Start();
    ContinueToNextPart();
    ws.Start();
  }

  private static void ContinueToNextPart()
  {
    Console.WriteLine("\nPRESS ENTER TO CONTINUE TO THE NEXT PART");
    Console.ReadLine();
    Console.Clear();
  }
}
