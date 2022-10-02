// See https://aka.ms/new-console-template for more information
namespace A1
{
  class Program
  {
    static void Main(string[] args)
    {
      // vars
      Helper h = Helper.GetInstance();
      Pet p = new Pet();
      TicketSeller ts = new TicketSeller();
      Album a = new Album();

      h.Setup();

      // sections
      h.Section("Pet Owner", () => p.Start());
      h.Section("Ticket Seller", () => ts.Start());
      h.Section("Album", () => a.Start());
      Console.Title = "Clock";
      // list timezones available and associate a number with each
      int i = 0;
      foreach (TimeZoneInfo tzi in TimeZoneInfo.GetSystemTimeZones())
      {
        Console.WriteLine(i + ": " + tzi.DisplayName);
        i++;
      }
      // get timezone from users choice
      Clock c = new Clock(TimeZoneInfo.GetSystemTimeZones()[int.Parse(h.getString("Enter the number of the timezone you want to check: "))].Id);
      c.DisplayTime();

      h.Cleanup();
    }
  }
}
