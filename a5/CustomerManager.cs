

public class CustomerManager
{
  private List<Customer> customers;

  public CustomerManager() {
    customers = new List<Customer>();
  }

  public void AddCustomer(Customer customer) {
    customers.Add(customer);
  }

  public void ChangeCustomer(Customer customer, int index) {

    customers[index] = new Customer(customer);
  }

  public void RemoveCustomer(int index) {
    customers.RemoveAt(index);
  }

  public Customer GetCustomer(int index) {
    return customers[index];
  }

  public Address GetAddressInfo(int index) {
    return customers[index].Contact.Address;
  }

  public Phone GetPhoneInfo(int index) {
    return customers[index].Contact.Phone;
  }

  public Email GetEmailInfo(int index) {
    return customers[index].Contact.Email;
  }

  public string GetFirstName(int index) {
    return customers[index].Contact.FirstName;
  }

  public string GetLastName(int index) {
    return customers[index].Contact.LastName;
  }

  public bool CheckIndex(int index) {
    return index < customers.Count;
  }

  public List<Customer> getCustomers() {
    return customers;
  }

  public int Count() {
    return customers.Count;
  }

  public void TestData() {
    customers.Add(new Customer(new Contact(
      "John",
      "Smith",
      new Address("123 Main St.", "Anytown", 12345, Countries.United_States_of_America),
      new Phone("123-456-7890"),
      new Email("JohnSmith@gmail.com")
    ), 1));
  }
}
