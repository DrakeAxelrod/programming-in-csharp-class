class TemperatureConverter {
  public double CelsiusToFahrenheit(double celsius) {
    return celsius * 9 / 5 + 32;
  }
  public double FahrenheitToCelsius(double fahrenheit) {
    return (fahrenheit - 32) * 5 / 9;
  }

  public void ShowMenu() {
    Console.WriteLine(" ===== Main Menu ===== ");
    Console.WriteLine("1. Convert from Celsius to Fahrenheit");
    Console.WriteLine("2. Convert from Fahrenheit to Celsius");
    Console.WriteLine("3. Exit");
  }

  public void ShowTableCelsiusToFahrenheit() {
    Console.WriteLine("Celsius\tFahrenheit");
    for (int i = 0; i <= 100; i++) {
      if (i % 4 == 0) Console.WriteLine("{0} C =\t{1} F", i, this.CelsiusToFahrenheit(i));
    }
  }

  public void ShowTableFahrenheitToCelsius() {
    Console.WriteLine("Fahrenheit\tCelsius");
    for (int i = 0; i <= 212; i++) {
      if (i % 10 == 0) Console.WriteLine("{0} F =\t{1} C", i, Math.Round(this.FahrenheitToCelsius(i),2));
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
          ShowTableCelsiusToFahrenheit();
          break;
        case 2:
          ShowTableFahrenheitToCelsius();
          break;
        case 3:
          done = true;
          break;
        default:
          Console.WriteLine("Invalid choice!");
          break;
      }
    } while (!done);
  }
}
