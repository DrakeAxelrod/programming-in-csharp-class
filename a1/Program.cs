// See https://aka.ms/new-console-template for more information
namespace A1
{
  class Program
  {
    private static void NextPart()
    {
      Console.WriteLine();
      Console.WriteLine("Press enter to start next part!");
      Console.ReadLine();
    }
    static void Main(string[] args)
    {
      Console.BackgroundColor = ConsoleColor.Gray;
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Title = "Pet Owner";

      // Console.WriteLine("Hello World!");
      Pet petObj = new Pet();
      petObj.Start();

      NextPart();
    }
  }
}
