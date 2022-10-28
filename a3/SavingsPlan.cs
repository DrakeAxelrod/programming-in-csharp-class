namespace a3;

class SavingsPlan {
  private double savings;
  private double monthlyDeposit;
  private int years;
  private double interestRate;
  private double fees;

  public double CalculateAmountPaid () {
    double amountPaid = 0;
    double saved = this.savings;
    double feePercent = 0;
    double interestPercent = 0;
    for (int i = 0; i < years; i++) {
      feePercent = saved * (fees / 100);
      interestPercent = saved * (interestRate / 100);
      saved = saved + monthlyDeposit + interestPercent - feePercent;
      amountPaid = amountPaid + feePercent;
    }
    return amountPaid;
  }

  public double CalculateAmountEarned () {
    return 10;
  }

  public double CalculateFinalBalance () {
    return 0;
  }

  public double CalculateTotalFees () {
    return 0;
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
