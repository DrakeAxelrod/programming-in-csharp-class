namespace a5;

public partial class CustomerForm : Form
{
  // enum edit or add
  public enum EditOrAdd { Edit, Add };
    // private BMICalculator bmiCalc = new BMICalculator();

    /// <summary>
    /// initialize the form
    /// </summary>
    public CustomerForm(EditOrAdd e, Contact contact)
    {
        InitializeComponent(e, contact);
    }
}
