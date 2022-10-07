class WorkingSchedule {
  
  public void ShowMenu() {
    Console.WriteLine(" ===== Main Menu ===== ");
    Console.WriteLine("1. Show a list of the weekends to work.");
    Console.WriteLine("2. Show a list of the nights to work.");
    Console.WriteLine("3. Exit");
  }

  public void ShowWeekends() {
    Console.WriteLine("Weekends to work:");
    for (int i = 1; i <= 52; i+=2) {
      Console.WriteLine("Week {0}", i);
    }
  }

  public void ShowNights() {
    Console.WriteLine("Nights to work:");
    for (int i = 1; i <= 52; i+=3) {
      Console.WriteLine("week {0}", i);
    }
  }

  public void Start() {
    bool done = false;
    do {
      ShowMenu();
      Console.Write("Enter your choice: ");
      int choice = Convert.ToInt32(Console.ReadLine());
      switch (choice) {
        case 1:
          ShowWeekends();
          break;
        case 2:
          ShowNights();
          break;
        case 0:
          done = true;
          break;
        default:
          Console.WriteLine("Invalid choice!");
          break;
      }
    } while (!done);
  }
}
