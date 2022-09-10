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

      h.Cleanup();
    }
  }
}
