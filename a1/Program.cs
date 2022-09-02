// See https://aka.ms/new-console-template for more information
namespace A1 {
  class Program
  {
      static void Main(string[] args)
      {
          Console.BackgroundColor = ConsoleColor.Gray;
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.Black;
          Console.Title = "Pet Owner";

          // Console.WriteLine("Hello World!");
          Pet petObj = new Pet();
          petObj.Start();
          
          Console.WriteLine("Press enter to start next object!");
          Console.ReadLine();
      }
  }
}
