

public class Customer
{
  private int id;
  private Contact contact;

  public Customer() {
  }

  public Customer(Customer theOther) {
    this.contact = theOther.contact;
  }

  public Customer(Contact contact, int id) {
    this.contact = contact;
    this.id = id;
  }

  public Contact Contact {
    get { return contact; }
    set { contact = value; }
  }

  public int ID {
    get { return id; }
    set { id = value; }
  }

  public string GetToStringItemsHeadings
  {
      get { return string.Format("{0,-23} {1}", this.id, this.contact.GetToStringItemsHeadings); }
  }

  public override string ToString() {
    string strOut = "";
    strOut += contact.FirstName + " " + contact.LastName + Environment.NewLine;
    strOut += contact.Address.ToString();
    strOut += contact.Email.ToString();
    strOut += contact.Phone.ToString();
    return strOut;
  }
}
