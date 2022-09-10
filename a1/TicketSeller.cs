namespace A1
{
  class TicketSeller {
    private static double TICKET_PRICE = 100.00;
    private static double CHILD_DISCOUNT = 0.25; // 25% of the price of a ticket
    private string name;
    private int nchild;
    private int nadult;
    private double total;
    private static Helper h = new Helper();
    public TicketSeller() {
      // technically not needed, but good practice
      // would have been better to get the values from the user before making the object
      this.name = "No name";
      this.nchild = 0;
      this.nadult = 0;
      this.total = 0.0;
    }

    public void Start() {
      // start the program
      Console.WriteLine("Welcome to KIDS' FAIR!");
      Console.WriteLine("Children always get a 75% discount!");
      Console.WriteLine();

      ReadAndSaveTicketData();
      DisplayTicketInfo();
    }

    public void ReadAndSaveTicketData() {
      // Read and save ticket seller's name
      this.SetName(h.getString("What is your name? "));
      // Read and save number of children
      this.SetNChild(int.Parse(h.getString("How many children are you buying tickets for? ")));
      // Read and save number of adults
      this.SetNAdult(int.Parse(h.getString("How many adults are you buying tickets for? ")));
      // Calculate total
      int childtotal = (int)(this.GetNChild() * TICKET_PRICE * CHILD_DISCOUNT);
      this.SetTotal(((TICKET_PRICE * nchild) * CHILD_DISCOUNT) + (nadult * TICKET_PRICE));
    }

    public void DisplayTicketInfo() {
      Console.WriteLine();
      Console.WriteLine("+++ Your Receipt +++");
      Console.WriteLine("+++ Amount to pay = " + this.GetTotal() + " +++");
      Console.WriteLine();
      Console.WriteLine("+++ Thank you " + this.GetName() + " and please come back! +++");
    }

    // setters
    public void SetName(string name) { this.name = name; }
    public void SetNChild(int nchild) { this.nchild = nchild; }
    public void SetNAdult(int nadult) { this.nadult = nadult; }
    public void SetTotal(double total) { this.total = total; }

    // getters
    public string GetName() { return name; }
    public int GetNChild() { return nchild; }
    public int GetNAdult() { return nadult; }
    public double GetTotal() { return total; }


  }
}
