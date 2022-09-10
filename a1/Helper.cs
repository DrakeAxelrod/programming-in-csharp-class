namespace A1
{
  class Helper
  {
    // singleton pattern
    private static Helper h = new Helper();
    private Helper() { }
    public static Helper GetInstance() { return h; }

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
    public void Section(string t, Action a) {
      Console.Title = t;
      a();
      Console.WriteLine();
      Console.WriteLine("Press enter to start next part!");
      Console.ReadLine();
    }

    public void Setup() {
      Console.BackgroundColor = ConsoleColor.Gray;
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Black;
    }

    public void Cleanup() {
      Console.ResetColor();
    }
  }
}
