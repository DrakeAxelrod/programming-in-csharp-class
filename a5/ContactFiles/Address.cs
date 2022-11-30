

public class Address {

  private string street;
  private string city;
  private int zip;
  private Countries country;

  public Address() {
  }

  public Address(Address theOther) {
    this.street = theOther.street;
    this.city = theOther.city;
    this.zip = theOther.zip;
    this.country = theOther.country;
  }

  public Address(string street, string city, int zip, Countries country) {
    this.street = street;
    this.city = city;
    this.zip = zip;
    this.country = country;
  }


  public string Street {
    get { return street; }
    set { street = value; }
  }

  public string City {
    get { return city; }
    set { city = value; }
  }

  public int Zip {
    get { return zip; }
    set { zip = value; }
  }

  public Countries Country {
    get { return country; }
    set { country = value; }
  }

  public string GetToStringItemsHeadings
  {
      get { return string.Format("{0,-20}, {1,-20}, {2,-20}, {3,-20}", this.street, this.city, this.zip, this.country); }
  }

  public override string ToString() {
    string strOut = "";
    strOut += "Street: " + street + "\n";
    strOut += "City: " + city + "\n";
    strOut += "Zip: " + zip + "\n";
    strOut += "Country: " + country + "\n";
    return strOut;
  }
}
