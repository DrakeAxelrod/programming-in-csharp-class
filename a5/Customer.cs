

public class Customer
{
  //id
  private int id;
  //contact
  private Contact contact;

  /// <summary>
  /// default constructor
  /// </summary>
  public Customer() {
  }

  /// <summary>
  /// constructor with one parameter - calls the constructor with
  /// more parameters, using a default value as the second argument.
  /// </summary>
  public Customer(Customer theOther) {
    this.contact = theOther.contact;
  }

  /// <summary>
  /// constructor with all parameters. This is  constructor that has most
  /// number of parameters. It is in this constructor that all coding
  /// should be done.
  /// </summary>
  public Customer(Contact contact, int id) {
    this.contact = contact;
    this.id = id;
  }

  /// <summary>
  /// property related to the field contact
  /// both read and write access
  /// </summary>
  public Contact Contact {
    get { return contact; }
    set { contact = value; }
  }

  /// <summary>
  /// property related to the field id
  /// both read and write access
  /// </summary>
  public int ID {
    get { return id; }
    set { id = value; }
  }

  /// <summary>
  /// returns a string representation of the object
  /// </summary>
  public string GetToStringItemsHeadings
  {
      get { return string.Format("{0,-23} {1}", this.id, this.contact.GetToStringItemsHeadings); }
  }

  /// <summary>
  /// returns a string representation of the object
  /// </summary>
  public override string ToString() {
    string strOut = "";
    strOut += contact.FirstName + " " + contact.LastName + Environment.NewLine;
    strOut += contact.Address.ToString();
    strOut += contact.Email.ToString();
    strOut += contact.Phone.ToString();
    return strOut;
  }
}
