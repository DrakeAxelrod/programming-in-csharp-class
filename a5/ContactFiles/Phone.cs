

public class Phone {

  //personal phone number
  private string personalPhone;
  //work phone number
  private string officePhone;

  /// <summary>
  /// Default constructor
  /// </summary>
  public Phone() {
  }

  /// <summary>
  /// Constructor with one parameter - calls the constructor with
  /// more parameters, using a default value as the second argument.
  /// </summary>
  public Phone(string officePhone) : this(officePhone, string.Empty) {
  }

  /// <summary>
  /// Constructor with all parameters. This is  constructor that has most
  /// number of parameters. It is in this constructor that all coding
  /// should be done.
  /// </summary>
  public Phone(Phone theOther) {
    this.personalPhone = theOther.personalPhone;
    this.officePhone = theOther.officePhone;
  }

  /// <summary>
  /// Constructor with all parameters. This is  constructor that has most
  /// number of parameters. It is in this constructor that all coding
  /// should be done.
  /// </summary>
  public Phone(string officePhone, string personalPhone) {
    this.officePhone = officePhone;
    this.personalPhone = personalPhone;
  }

  /// <summary>
  /// Property related to the field personalPhone
  /// Both read and write access
  /// </summary>
  public string Personal {
    get { return personalPhone; }
    set { personalPhone = value; }
  }

  /// <summary>
  /// Property related to the field officePhone
  /// Both read and write access
  /// </summary>
  public string Work {
    get { return officePhone; }
    set { officePhone = value; }
  }

  /// <summary>
  /// Returns a string representation of the object
  /// for list of contacts
  /// </summary>
  public string GetToStringItemsHeadings
  {
      get { return string.Format("{0,-20}", this.officePhone); }
  }

  /// <summary>
  /// Returns a string representation of the object
  /// </summary>
  public override string ToString() {
    string strOut = Environment.NewLine + "Phone number" + Environment.NewLine;

    strOut += string.Format(" {0,-10} {1, -10}", "Private", personalPhone) + Environment.NewLine;
    strOut += string.Format(" {0,-10} {1, -10}", "Office", officePhone) + Environment.NewLine;

    return strOut;
  }
}
