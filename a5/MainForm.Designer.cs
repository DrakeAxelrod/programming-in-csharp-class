namespace a5;

partial class MainForm
{
  /// <summary>
  ///  Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;


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
}
