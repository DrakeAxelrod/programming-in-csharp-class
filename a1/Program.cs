// See https://aka.ms/new-console-template for more information
namespace A1
{
  class Helper { 
    // should have just made an input class to handle all inputs
    // singleton pattern would have been better
    public void SpacedText(string text)
    {
      Console.WriteLine();
      Console.WriteLine(text);
      Console.WriteLine();
    }
    public string getString(string text)
    {
      Console.Write(text);
      return Console.ReadLine() + ""; // + "" to convert null to ""
    }
  }
  class Program
  {
    private static Helper h = new Helper();

    // takes an anonymous function as a parameter
    private static void Section(Action a) {
      a();
      Console.WriteLine();
      Console.WriteLine("Press enter to start next part!");
      Console.ReadLine();
    }

    private static void Setup() {
      Console.BackgroundColor = ConsoleColor.Gray;
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Black;
    }

    static void Main(string[] args)
    {
      Pet p = new Pet();
      TicketSeller ts = new TicketSeller();
      Album a = new Album();
      Setup();
      // pet section
      Console.Title = "Pet Owner";
      Section(() => p.Start());
      // ticket seller section
      Console.Title = "Ticket Seller";
      Section(() => ts.Start());
      // album section
      Console.Title = "Album Collection";
      Section(() => a.Start());
      Console.ResetColor();
    }
  }
}
