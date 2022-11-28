namespace a5;

public partial class AddCustomerForm : Form
{
  // enum edit or add
  public enum EditOrAdd { Edit, Add };
    // private BMICalculator bmiCalc = new BMICalculator();

    /// <summary>
    /// initialize the form
    /// </summary>
    public AddCustomerForm(EditOrAdd e)
    {
        InitializeComponent(e);
    }
}
