

public class Address {
  //street address
  private string street;
  //city
  private string city;
  //zip code
  private int zip;
  //country
  private Countries country;


  /// <summary>
  /// Default constructor
  /// </summary>
  public Address() {
  }

  /// <summary>
  /// Constructor with one parameter - calls the constructor with
  /// more parameters, using a default value as the second argument.
  /// </summary>
  public Address(Address theOther) {
    this.street = theOther.street;
    this.city = theOther.city;
    this.zip = theOther.zip;
    this.country = theOther.country;
  }

  /// <summary>
  /// Constructor with all parameters. This is  constructor that has most
  /// number of parameters. It is in this constructor that all coding
  /// should be done.
  /// </summary>
  public Address(string street, string city, int zip, Countries country) {
    this.street = street;
    this.city = city;
    this.zip = zip;
    this.country = country;
  }


  /// <summary>
  /// Property related to the field street
  /// Both read and write access
  /// </summary>
  public string Street {
    get { return street; }
    set { street = value; }
  }

  /// <summary>
  /// Property related to the field city
  /// Both read and write access
  /// </summary>
  public string City {
    get { return city; }
    set { city = value; }
  }

  /// <summary>
  /// Property related to the field zip
  /// Both read and write access
  /// </summary>
  public int Zip {
    get { return zip; }
    set { zip = value; }
  }

  /// <summary>
  /// Property related to the field country
  /// Both read and write access
  /// </summary>
  public Countries Country {
    get { return country; }
    set { country = value; }
  }

  /// <summary>
  /// Returns a string representation of the object
  /// for the list of contacts
  /// </summary>
  public string GetToStringItemsHeadings
  {
      get { return string.Format("{0,-20}, {1,-20}, {2,-20}, {3,-20}", this.street, this.city, this.zip, this.country); }
  }

  /// <summary>
  /// Returns a string representation of the object
  /// </summary>
  public override string ToString() {
    string strOut = "";
    strOut +=  city + Environment.NewLine;
    strOut +=  string.Format("{0} {1}", zip, street) + Environment.NewLine;
    // replace _ with space
    string strCountry = country.ToString().Replace("_", " ");
    strOut += strCountry + Environment.NewLine;
    return strOut;
  }
}
