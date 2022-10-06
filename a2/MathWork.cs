class MathWork {

  public void SumberNumbers() {
    bool repeat = true;
    do {
      Console.Write("Enter starting number: ");
      int start = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter ending number: ");
      int end = Convert.ToInt32(Console.ReadLine());
      int sum = this.SumNumbers(start, end);
      Console.WriteLine("The sum of the numbers between {0} and {1} is {2}", start, end, sum);
      this.PrimeEventNumbers(start, end);
      Console.WriteLine();
      Console.WriteLine("Do you want to sum more numbers? (y/n)");
      string ans = Console.ReadLine().ToLower() ?? "";
      repeat = ans == "y" || ans == "yes" ? true : false;
    } while (repeat);
  }

  public void PrimeEventNumbers(int n1, int n2) {
    Console.WriteLine("The prime numbers between {0} and {1}", n1, n2);
    for (int i = n1; i <= n2; i++) {
      if (i % 2 == 0) {
        Console.Write("{0} ", i);
      }
    }
  }

  public void PrintMultiplicationTable() {
    Console.WriteLine("           ********** Multiplication Table **********           ");
    for (int i = 1; i <= 12; i++) {
      for (int j = 1; j <= 12; j++) {
        Console.Write(String.Format("{0,4:d} ", i * j));
      }
      Console.WriteLine();
    }
  }

  private int SumNumbers(int startNum, int endNum) {
    int sum = 0;
    for (int i = startNum; i <= endNum; i++) {
      sum += i;
    }
    return sum;
  }

  public void Start() {
    SumberNumbers();
    PrintMultiplicationTable();
  }
}
