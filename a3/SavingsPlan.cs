namespace a3;

class SavingsPlan {
  private double savings;
  private double monthlyDeposit;
  private int years;
  private double interestRate; // in percent
  private double fees; // in percent

  public Dictionary<string, double> Calculate() {
    int months = years * 12;
    double interestEarned = 0;
    double balance = 0;
    double expense = 0;
    double amountPaid = 0;
    double totalFees = 0;
    double amountEarned = 0;
    double interest = interestRate / 100;
    double feesRate = fees / 100;
    balance = savings;
    amountPaid = months * monthlyDeposit;
    for (int i = 0; i < months; i++) {
      interestEarned = (interest / 12) * balance;
      if (i % 12 == 0) {
        expense = balance * feesRate;
        balance -= expense;
        totalFees += expense;
      }
      amountEarned += interestEarned;
      balance += monthlyDeposit + interestEarned;
    }
    return new Dictionary<string, double> {
      { "amountPaid", amountPaid },
      { "amountEarned", amountEarned },
      { "totalFees", totalFees },
      { "finalBalance", balance }
    };
  }

  // getters and setters
  public double getSavings () {
    return savings;
  }
  public void setSavings (double s) {
    this.savings = s;
  }
  public double getMonthlyDeposit () {
    return monthlyDeposit;
  }
  public void setMonthlyDeposit (double m) {
    this.monthlyDeposit = m;
  }
  public int getYears () {
    return years;
  }
  public void setYears (int y) {
    this.years = y;
  }
  public double getInterestRate () {
    return interestRate;
  }
  public void setInterestRate (double i) {
    this.interestRate = i;
  }
  public double getFees () {
    return fees;
  }
  public void setFees (double f) {
    this.fees = f;
  }
}
