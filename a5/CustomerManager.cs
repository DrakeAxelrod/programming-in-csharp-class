

public class CustomerManager
{
  //list of customers
  private List<Customer> customers;

  /// <summary>
  /// default constructor
  /// </summary>
  public CustomerManager() {
    customers = new List<Customer>();
  }

  /// <summary>
  /// constructor with one parameter - calls the constructor with
  /// more parameters, using a default value as the second argument.
  /// </summary>
  public void AddCustomer(Customer customer) {
    customers.Add(customer);
  }

  /// <summary>
  /// constructor with all parameters. This is  constructor that has most
  /// number of parameters. It is in this constructor that all coding
  /// should be done.
  /// </summary>
  public void ChangeCustomer(Customer customer, int index) {
    customers[index] = new Customer(customer);
  }

  /// <summary>
  /// removes a customer from the list
  /// </summary>
  public void RemoveCustomer(int index) {
    customers.RemoveAt(index);
  }

  /// <summary>
  /// gets a customer from the list
  /// </summary>
  public Customer GetCustomer(int index) {
    return customers[index];
  }

  /// <summary>
  /// get address of a customer
  /// </summary>
  public Address GetAddressInfo(int index) {
    return customers[index].Contact.Address;
  }

  /// <summary>
  /// get phone of a customer
  /// </summary>
  public Phone GetPhoneInfo(int index) {
    return customers[index].Contact.Phone;
  }

  /// <summary>
  /// get email of a customer
  /// </summary>
  public Email GetEmailInfo(int index) {
    return customers[index].Contact.Email;
  }

  /// <summary>
  /// get first name of a customer
  /// </summary>
  public string GetFirstName(int index) {
    return customers[index].Contact.FirstName;
  }

  /// <summary>
  /// get last name of a customer
  /// </summary>
  public string GetLastName(int index) {
    return customers[index].Contact.LastName;
  }

  /// <summary>
  /// check the list at the index for a customer
  /// </summary>
  public bool CheckIndex(int index) {
    return index < customers.Count;
  }

  /// <summary>
  /// get the customer list
  /// </summary>
  public List<Customer> getCustomers() {
    return customers;
  }

  /// <summary>
  /// get the number of customers in the list
  /// </summary>
  public int Count() {
    return customers.Count;
  }

  /// <summary>
  /// test data for the customer list
  /// </summary>
  public void TestData() {

    customers.Add(new Customer(new Contact(
      "John",
      "Smith",
      new Address("123 Main St.", "Anytown", 12345, Countries.United_States_of_America),
      new Phone("123-456-7890", "098-765-4321"),
      new Email("JohnSmith@gmail.com", "jsmith@gmail.com")
    ), 1));
  }
}
