

public class Phone {
  private string personalPhone;
  private string officePhone;

  public Phone() {
  }

  public Phone(string officePhone) : this(officePhone, string.Empty) {
  }

  public Phone(Phone theOther) {
    this.personalPhone = theOther.personalPhone;
    this.officePhone = theOther.officePhone;
  }

  public Phone(string officePhone, string personalPhone) {
    this.officePhone = officePhone;
    this.personalPhone = personalPhone;
  }

  public string Personal {
    get { return personalPhone; }
    set { personalPhone = value; }
  }

  public string Work {
    get { return officePhone; }
    set { officePhone = value; }
  }

  public string GetToStringItemsHeadings
  {
      get { return string.Format("{0,-20}", this.officePhone); }
  }

  public override string ToString() {
    string strOut = Environment.NewLine + "Phone number" + Environment.NewLine;

    strOut += string.Format(" {0,-10} {1, -10}", "Private", personalPhone) + Environment.NewLine;
    strOut += string.Format(" {0,-10} {1, -10}", "Office", officePhone) + Environment.NewLine;

    return strOut;
  }
}
