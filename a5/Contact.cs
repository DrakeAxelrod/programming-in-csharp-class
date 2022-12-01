
public class Contact
{
  //address
  private Address address;
  //phone
  private Phone phone;
  //email
  private Email email;
  //first name
  private string firstName;
  //last name
  private string lastName;

  /// <summary>
  /// Default constructor
  /// </summary>
  public Contact() {
  }

  /// <summary>
  /// Constructor with one parameter - calls the constructor with
  /// more parameters, using a default value as the second argument.
  /// </summary>
  public Contact(Contact theOther) {
    this.address = theOther.address;
    this.phone = theOther.phone;
    this.email = theOther.email;
    this.firstName = theOther.firstName;
    this.lastName = theOther.lastName;
  }

  /// <summary>
  /// Constructor with all parameters. This is  constructor that has most
  /// number of parameters. It is in this constructor that all coding
  /// should be done.
  /// </summary>
  public Contact(string firstName, string lastName, Address address, Phone phone, Email email) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.address = address;
    this.phone = phone;
    this.email = email;
  }

  /// <summary>
  /// Property related to the field firstName
  /// Both read and write access
  /// </summary>
  public string FirstName {
    get { return firstName; }
    set { firstName = value; }
  }

  /// <summary>
  /// Property related to the field lastName
  /// Both read and write access
  /// </summary>
  public string LastName {
    get { return lastName; }
    set { lastName = value; }
  }

  /// <summary>
  /// Property related to the field address
  /// Both read and write access
  /// </summary>
  public Address Address {
    get { return address; }
    set { address = value; }
  }

  /// <summary>
  /// Property related to the field phone
  /// Both read and write access
  /// </summary>
  public Phone Phone {
    get { return phone; }
    set { phone = value; }
  }

  /// <summary>
  /// Property related to the field email
  /// Both read and write access
  /// </summary>
  public Email Email {
    get { return email; }
    set { email = value; }
  }

  /// <summary>
  /// Property related to the field country
  /// Both read and write access
  /// </summary>
  public Countries Country
  {
      get { return address.Country; }
      set { address.Country = value; }
  }

  /// <summary>
  /// string representation of the object
  /// </summary>
  public string GetToStringItemsHeadings
  {
      get { return string.Format("{0},{1,-74}{2,-38}{3}", this.firstName, this.lastName, this.phone.GetToStringItemsHeadings, this.email.GetToStringItemsHeadings); }
  }
}
