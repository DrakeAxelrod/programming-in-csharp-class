namespace a5;

partial class MainForm
{
  /// <summary>
  ///  Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  private int HEIGHT = 500;
  private int WIDTH = 1000;

  private System.Windows.Forms.Label lblSections;
  private System.Windows.Forms.ListBox lstContacts;
  private System.Windows.Forms.TextBox txtContactDetails;
  // buttons (add, edit, delete)
  private System.Windows.Forms.Button btnAdd;
  private System.Windows.Forms.Button btnEdit;
  private System.Windows.Forms.Button btnDelete;

  private CustomerManager cm;
  /// <summary>
  ///  Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
    {
      components.Dispose();
    }
    base.Dispose(disposing);
  }

  /// <summary>
  ///  Required method for Designer support - do not modify
  ///  the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
    this.cm = new CustomerManager();
    this.components = new System.ComponentModel.Container();
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(WIDTH, HEIGHT);
    this.Text = "Customer Registry By Drake Axelrod";
    int width = WIDTH -60;
    String sections =
      "ID"                            + new String(' ', 15)
      + "Name (Surname, first name)"  + new String(' ', 20)
      + "Office Phone"                + new String(' ', 15)
      + "Office Email"                + new String(' ', 40)
      + "Contact Details";
    // larger text and cyan color
    lblSections = createLabel("lblSections", sections, 30, 30, 1000, 30, 0);
    System.Drawing.Font font = System.Drawing.SystemFonts.DefaultFont;
    this.lblSections.Font = new System.Drawing.Font(font.Name, 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.lblSections.ForeColor = System.Drawing.Color.DarkCyan;
    this.Controls.Add(this.lblSections);

    // list box
    // 2/3 of the width
    lstContacts = createListBox("lstContacts", 30, 60, (int)(width * 2.0/3.0), 380, 1);
    // four columns for the list box (ID, Name, Office Phone, Office Email)

    this.Controls.Add(this.lstContacts);

    // text box
    // 1/3 of the width
    txtContactDetails = createTextBox("txtContactDetails", (int)(width * 2.0/3.0) + 30, 59, (int)(width * 1.0/3.0), 380, 2);
    // multiline
    txtContactDetails.Multiline = true;
    // disable for writing
    txtContactDetails.ReadOnly = true;
    this.Controls.Add(this.txtContactDetails);

    // buttons centered across list box
    int buttonWidth = (int)(width * 2.0/3.0) / 3;
    btnAdd = createButton("btnAdd", "Add", 30, 450, buttonWidth, 30, 3);
    btnEdit = createButton("btnEdit", "Edit", 30 + buttonWidth, 450, buttonWidth, 30, 4);
    btnDelete = createButton("btnDelete", "Delete", 30 + buttonWidth * 2, 450, buttonWidth, 30, 5);
    // add event handlers
    btnAdd.Click += new System.EventHandler(this.btn_Click);
    btnEdit.Click += new System.EventHandler(this.btn_Click);
    btnDelete.Click += new System.EventHandler(this.btn_Click);
    this.Controls.Add(this.btnAdd);
    this.Controls.Add(this.btnEdit);
    this.Controls.Add(this.btnDelete);

    cm.TestData();
    // populate the list box
    updateListBox();
  }

  // initialize label
  private System.Windows.Forms.Label createLabel(string name, string text, int x, int y, int width, int height, int tabIndex)
  {
    System.Windows.Forms.Label label = new System.Windows.Forms.Label();
    label.Location = new System.Drawing.Point(x, y);
    label.Name = name;
    label.Size = new System.Drawing.Size(width, height);
    label.TabIndex = tabIndex;
    label.Text = text;
    return label;
  }

  // initialize text box
  private System.Windows.Forms.TextBox createTextBox(string name, int x, int y, int width, int height, int tabIndex)
  {
    System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
    textBox.Location = new System.Drawing.Point(x, y);
    textBox.Name = name;
    textBox.Size = new System.Drawing.Size(width, height);
    textBox.TabIndex = tabIndex;
    return textBox;
  }

  // initialize radio button
  private System.Windows.Forms.RadioButton createRadioButton(string name, string text, int x, int y, int width, int height, int tabIndex)
  {
    System.Windows.Forms.RadioButton radioButton = new System.Windows.Forms.RadioButton();
    radioButton.Location = new System.Drawing.Point(x, y);
    radioButton.Name = name;
    radioButton.Size = new System.Drawing.Size(width, height);
    radioButton.TabIndex = tabIndex;
    radioButton.TabStop = true;
    radioButton.Text = text;
    radioButton.UseVisualStyleBackColor = true;
    return radioButton;
  }

  // initialize button
  private System.Windows.Forms.Button createButton(string name, string text, int x, int y, int width, int height, int tabIndex)
  {
    System.Windows.Forms.Button button = new System.Windows.Forms.Button();
    button.Location = new System.Drawing.Point(x, y);
    button.Name = name;
    button.Size = new System.Drawing.Size(width, height);
    button.TabIndex = tabIndex;
    button.Text = text;
    return button;
  }

  // initialize list box
  private System.Windows.Forms.ListBox createListBox(string name, int x, int y, int width, int height, int tabIndex)
  {
    System.Windows.Forms.ListBox listBox = new System.Windows.Forms.ListBox();
    listBox.Location = new System.Drawing.Point(x, y);
    listBox.Name = name;
    listBox.Size = new System.Drawing.Size(width, height);
    listBox.TabIndex = tabIndex;
    return listBox;
  }

  private void updateListBox()
  {
    // clear list box
    lstContacts.Items.Clear();
    // add all contacts to list box
    foreach (Customer c in cm.getCustomers())
    {
      lstContacts.Items.Add(c.GetToStringItemsHeadings);
    }
  }

  // handle button clicks
  private void btn_Click(object sender, EventArgs e)
  {
    if (sender == btnAdd)
    {
      // create new contact
      Contact contact = new Contact();
      // create new Customer
      Customer customer = new Customer();
      customer.Contact = contact;
      // create new customer form
      CustomerForm cf = new CustomerForm(CustomerForm.EditOrAdd.Add, contact);
      cf.Show();
      customer.ID = cm.Count() + 1;
      cm.AddCustomer(customer);
      // update list box
      updateListBox();
    }
    else if (sender == btnEdit)
    {
      // get selected customer
      Customer customer = cm.GetCustomer(lstContacts.SelectedIndex);
      // create new customer form
      CustomerForm cf = new CustomerForm(CustomerForm.EditOrAdd.Edit, customer.Contact);
      cf.Show();
    }
    else if (sender == btnDelete)
    {
      // get selected item
      int index = lstContacts.SelectedIndex;
      if (index >= 0)
      {
        // delete from list box
        cm.RemoveCustomer(index);
        lstContacts.Items.RemoveAt(index);
      }
    }
  }
}
