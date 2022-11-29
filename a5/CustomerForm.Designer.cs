namespace a5;

partial class CustomerForm
{
  /// <summary>
  ///  Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  private int HEIGHT = 500;
  private int WIDTH = 500;

  // name group box
  private System.Windows.Forms.GroupBox grpName;
  private System.Windows.Forms.Label lblFirstName;
  private System.Windows.Forms.Label lblLastName;
  private System.Windows.Forms.TextBox txtFirstName;
  private System.Windows.Forms.TextBox txtLastName;
  // email and phone group box
  private System.Windows.Forms.GroupBox grpEmailPhone;
  private System.Windows.Forms.Label lblHomePhone;
  private System.Windows.Forms.Label lblCellPhone;
  private System.Windows.Forms.Label lblEmailBusiness;
  private System.Windows.Forms.Label lblEmailPrivate;
  private System.Windows.Forms.TextBox txtHomePhone;
  private System.Windows.Forms.TextBox txtCellPhone;
  private System.Windows.Forms.TextBox txtEmailBusiness;
  private System.Windows.Forms.TextBox txtEmailPrivate;
  // address group box
  private System.Windows.Forms.GroupBox grpAddress;
  private System.Windows.Forms.Label lblStreet;
  private System.Windows.Forms.Label lblCity;
  private System.Windows.Forms.Label lblZipCode;
  private System.Windows.Forms.Label lblCountry;
  private System.Windows.Forms.TextBox txtStreet;
  private System.Windows.Forms.TextBox txtCity;
  private System.Windows.Forms.TextBox txtZipCode;
  // country combo box
  private System.Windows.Forms.ComboBox cmbCountry;
  // buttons
  private System.Windows.Forms.Button btnOK;
  private System.Windows.Forms.Button btnCancel;


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
  private void InitializeComponent(EditOrAdd e)
  {
    this.components = new System.ComponentModel.Container();
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(WIDTH, HEIGHT);
    this.Text = e == EditOrAdd.Add ? "Add Customer" : "Edit Customer";
  
    // groupbox's with height of HEIGHT/3 with space for buttons and with WIDTH - 60
    grpName = createGroupBox("grpName", "Name", 30, 0, WIDTH - 60, 100, 0);
    // name and last name centered in groupbox
    lblFirstName = createLabel("lblFirstName", "First Name", 10, 30, 100, 20, 0);
    lblLastName = createLabel("lblLastName", "Last Name", 10, 60, 100, 20, 0);
    txtFirstName = createTextBox("txtFirstName", 110, 26, 310, 20, 0);
    txtLastName = createTextBox("txtLastName", 110, 56, 310, 20, 0);
    grpEmailPhone = createGroupBox("grpEmailPhone", "Email and phone", 30, 110, WIDTH - 60, 150, 1);
    // email and phone centered in groupbox
    lblHomePhone = createLabel("lblHomePhone", "Home Phone", 10, 30, 100, 20, 1);
    lblCellPhone = createLabel("lblCellPhone", "Cell Phone", 10, 60, 100, 20, 1);
    lblEmailBusiness = createLabel("lblEmailBusiness", "Email Business", 10, 90, 100, 20, 1);
    lblEmailPrivate = createLabel("lblEmailPrivate", "Email Private", 10, 120, 100, 20, 1);
    txtHomePhone = createTextBox("txtHomePhone", 110, 26, 310, 20, 1);
    txtCellPhone = createTextBox("txtCellPhone", 110, 56, 310, 20, 1);
    txtEmailBusiness = createTextBox("txtEmailBusiness", 110, 86, 310, 20, 1);
    txtEmailPrivate = createTextBox("txtEmailPrivate", 110, 116, 310, 20, 1);
    grpAddress = createGroupBox("grpAddress", "Address", 30, 270, WIDTH - 60, 150, 2);
    // address centered in groupbox
    lblStreet = createLabel("lblStreet", "Street", 10, 30, 100, 20, 2);
    lblCity = createLabel("lblCity", "City", 10, 60, 100, 20, 2);
    lblZipCode = createLabel("lblZipCode", "Zip Code", 10, 90, 100, 20, 2);
    lblCountry = createLabel("lblCountry", "Country", 10, 120, 100, 20, 2);
    txtStreet = createTextBox("txtStreet", 110, 26, 310, 20, 2);
    txtCity = createTextBox("txtCity", 110, 56, 310, 20, 2);
    txtZipCode = createTextBox("txtZipCode", 110, 86, 310, 20, 2);
    // country combo box
    cmbCountry = createComboBox("cmbCountry", 110, 116, 310, 20, 2);
    // center buttons in the bottom of the form
    btnOK = createButton("btnOK", "OK", WIDTH/3 - 60, HEIGHT - 60, 100, 30, 3);
    btnCancel = createButton("btnCancel", "CANCEL", 2*WIDTH/3 - 30, HEIGHT - 60, 100, 30, 4);
    // add event handlers
    btnOK.Click += new System.EventHandler(this.btnOK_Click);
    btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
    // add to form
    this.Controls.Add(grpName);
    this.grpName.Controls.Add(lblFirstName);
    this.grpName.Controls.Add(lblLastName);
    this.grpName.Controls.Add(txtFirstName);
    this.grpName.Controls.Add(txtLastName);
    this.Controls.Add(grpEmailPhone);
    this.grpEmailPhone.Controls.Add(lblHomePhone);
    this.grpEmailPhone.Controls.Add(lblCellPhone);
    this.grpEmailPhone.Controls.Add(lblEmailBusiness);
    this.grpEmailPhone.Controls.Add(lblEmailPrivate);
    this.grpEmailPhone.Controls.Add(txtHomePhone);
    this.grpEmailPhone.Controls.Add(txtCellPhone);
    this.grpEmailPhone.Controls.Add(txtEmailBusiness);
    this.grpEmailPhone.Controls.Add(txtEmailPrivate);
    this.Controls.Add(grpAddress);
    this.grpAddress.Controls.Add(lblStreet);
    this.grpAddress.Controls.Add(lblCity);
    this.grpAddress.Controls.Add(lblZipCode);
    this.grpAddress.Controls.Add(lblCountry);
    this.grpAddress.Controls.Add(txtStreet);
    this.grpAddress.Controls.Add(txtCity);
    this.grpAddress.Controls.Add(txtZipCode);
    this.grpAddress.Controls.Add(cmbCountry);
    this.Controls.Add(btnOK);
    this.Controls.Add(btnCancel);




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

  // initialize combo box
  private System.Windows.Forms.ComboBox createComboBox(string name, int x, int y, int width, int height, int tabIndex)
  {
    System.Windows.Forms.ComboBox comboBox = new System.Windows.Forms.ComboBox();
    comboBox.Location = new System.Drawing.Point(x, y);
    comboBox.Name = name;
    comboBox.Size = new System.Drawing.Size(width, height);
    comboBox.TabIndex = tabIndex;
    return comboBox;
  }

  // initialize group box
  private System.Windows.Forms.GroupBox createGroupBox(string name, string text, int x, int y, int width, int height, int tabIndex)
  {
    System.Windows.Forms.GroupBox groupBox = new System.Windows.Forms.GroupBox();
    groupBox.Location = new System.Drawing.Point(x, y);
    groupBox.Name = name;
    groupBox.Size = new System.Drawing.Size(width, height);
    groupBox.TabIndex = tabIndex;
    groupBox.TabStop = false;
    groupBox.Text = text;
    return groupBox;
  }

  // event handler for OK button
  private void btnOK_Click(object sender, EventArgs e)
  {
    // check if all fields are filled
    if (txtFirstName.Text == "" || txtLastName.Text == "" || txtHomePhone.Text == "" || txtCellPhone.Text == "" || txtEmailBusiness.Text == "" || txtEmailPrivate.Text == "" || txtStreet.Text == "" || txtCity.Text == "" || txtZipCode.Text == "" || cmbCountry.Text == "")
    {
      MessageBox.Show("Please fill all fields!");
    }
    else
    {
      return;
    }
  }

  // event handler for cancel button
  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.Close();
  }
}
