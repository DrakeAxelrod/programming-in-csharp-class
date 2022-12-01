
public class Contact
{
  private Address address;
  private Phone phone;
  private Email email;
  private string firstName;
  private string lastName;

  public Contact() {
  }

  public Contact(Contact theOther) {
    this.address = theOther.address;
    this.phone = theOther.phone;
    this.email = theOther.email;
    this.firstName = theOther.firstName;
    this.lastName = theOther.lastName;
  }

  public Contact(string firstName, string lastName, Address address, Phone phone, Email email) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.address = address;
    this.phone = phone;
    this.email = email;
  }

  public string FirstName {
    get { return firstName; }
    set { firstName = value; }
  }

  public string LastName {
    get { return lastName; }
    set { lastName = value; }
  }

  public Address Address {
    get { return address; }
    set { address = value; }
  }

  public Phone Phone {
    get { return phone; }
    set { phone = value; }
  }

  public Email Email {
    get { return email; }
    set { email = value; }
  }

  public Countries Country
  {
      get { return address.Country; }
      set { address.Country = value; }
  }

  public string GetToStringItemsHeadings
  {
      get { return string.Format("{0},{1,-74}{2,-38}{3}", this.firstName, this.lastName, this.phone.GetToStringItemsHeadings, this.email.GetToStringItemsHeadings); }
  }
}
