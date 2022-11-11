namespace a4;

partial class IngredientsForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.GroupBox grpIngredient;
    private System.Windows.Forms.Label lblCurrNumber;
    private System.Windows.Forms.Label lblNumIngredients;
    private System.Windows.Forms.ListBox lstIngredients;
    private Recipe recipe;
    private System.Windows.Forms.TextBox txtNameIngredient;
    private int HEIGHT = 400;
    private int WIDTH = 400;
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
    private void InitializeComponent(Recipe recipe)
    {
        this.recipe = recipe;
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(WIDTH, HEIGHT);
        this.Text = recipe.Name + " -- add ingredients";
        // center form
        this.StartPosition = FormStartPosition.CenterScreen;
        // add NumIngredients label
        this.lblNumIngredients = initLabel(10, 10, 200, 20, "lblNumIngredients", "Number of ingredients", 0, false, true);
        this.Controls.Add(this.lblNumIngredients);
        // add CurrNumber label all the way to the right of the form
        this.lblCurrNumber = initLabel(WIDTH - 20, 10, 100, 20, "lblCurrNumber", "0", 0, false, true);
        // add event handler for lblCurrNumber
        this.lblCurrNumber.Click += new System.EventHandler(this.lblCurrNumber_Click);
        this.Controls.Add(this.lblCurrNumber);
        // init group box
        this.grpIngredient = initGrpBox(10, 30, WIDTH - 20, HEIGHT -95, "grpIngredient", "Ingredient", 0, false, true);
        this.Controls.Add(this.grpIngredient);
        // init ingredient name text box
        this.txtNameIngredient = initTextBox(10, 20, WIDTH - 110, 20, "txtNameIngredient", "", 0, false, true);
        this.grpIngredient.Controls.Add(this.txtNameIngredient);
        // init list box
        this.lstIngredients = initListBox(10, 50, WIDTH - 110, HEIGHT - 150, "lstIngredients", 0, false, true);
        // populate list box with recipe ingredients
        if (recipe.Ingredients != null)
        {
            foreach (string ingredient in recipe.Ingredients)
            {
                this.lstIngredients.Items.Add(ingredient);
            }
        }
        this.grpIngredient.Controls.Add(this.lstIngredients);
        // init add button
        this.btnAdd = initButton(WIDTH - 90, 20, 60, 30, "btnAdd", "Add", 0, false, true);
        // add event handler
        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
        this.grpIngredient.Controls.Add(this.btnAdd);
        // init edit button
        this.btnEdit = initButton(WIDTH - 90, 60, 60, 30, "btnEdit", "Edit", 0, false, true);
        // add event handler
        this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
        this.grpIngredient.Controls.Add(this.btnEdit);
        // init delete button
        this.btnDelete = initButton(WIDTH - 90, 100, 60, 30, "btnDelete", "Delete", 0, false, true);
        // add event handler
        this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
        this.grpIngredient.Controls.Add(this.btnDelete);
        // init ok button
        this.btnOk = initButton(WIDTH/2 - 90, HEIGHT - 55, 80, 40, "btnOk", "Ok", 0, false, true);
        // add event handler
        this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
        this.Controls.Add(this.btnOk);
        // init cancel button
        this.btnCancel = initButton(WIDTH/2, HEIGHT - 55, 80, 40, "btnCancel", "Cancel", 0, false, true);
        // add event handler
        this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
        this.Controls.Add(this.btnCancel);

    }


  private System.Windows.Forms.GroupBox initGrpBox(int x, int y, int width, int height, string name, string text, int tabIndex, bool tabStop, bool visible)
  {
    System.Windows.Forms.GroupBox grpBox = new System.Windows.Forms.GroupBox();
    grpBox.Location = new System.Drawing.Point(x, y);
    grpBox.Size = new System.Drawing.Size(width, height);
    grpBox.Name = name;
    grpBox.Text = text;
    grpBox.TabIndex = tabIndex;
    grpBox.TabStop = tabStop;
    grpBox.Visible = visible;
    return grpBox;
  }

  private System.Windows.Forms.Label initLabel(int x, int y, int width, int height, string name, string text, int tabIndex, bool tabStop, bool visible)
  {
    System.Windows.Forms.Label label = new System.Windows.Forms.Label();
    label.Location = new System.Drawing.Point(x, y);
    label.Size = new System.Drawing.Size(width, height);
    label.Name = name;
    label.Text = text;
    label.TabIndex = tabIndex;
    label.TabStop = tabStop;
    label.Visible = visible;
    return label;
  }

  private System.Windows.Forms.TextBox initTextBox(int x, int y, int width, int height, string name, string text, int tabIndex, bool tabStop, bool visible)
  {
    System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
    textBox.Location = new System.Drawing.Point(x, y);
    textBox.Size = new System.Drawing.Size(width, height);
    textBox.Name = name;
    textBox.Text = text;
    textBox.TabIndex = tabIndex;
    textBox.TabStop = tabStop;
    textBox.Visible = visible;
    return textBox;
  }

  private System.Windows.Forms.Button initButton(int x, int y, int width, int height, string name, string text, int tabIndex, bool tabStop, bool visible)
  {
    System.Windows.Forms.Button button = new System.Windows.Forms.Button();
    button.Location = new System.Drawing.Point(x, y);
    button.Size = new System.Drawing.Size(width, height);
    button.Name = name;
    button.Text = text;
    button.TabIndex = tabIndex;
    button.TabStop = tabStop;
    button.Visible = visible;
    return button;
  }

  private System.Windows.Forms.ListBox initListBox(int x, int y, int width, int height, string name, int tabIndex, bool tabStop, bool visible)
  {
    System.Windows.Forms.ListBox listBox = new System.Windows.Forms.ListBox();
    listBox.Location = new System.Drawing.Point(x, y);
    listBox.Size = new System.Drawing.Size(width, height);
    listBox.Name = name;
    listBox.TabIndex = tabIndex;
    listBox.TabStop = tabStop;
    listBox.Visible = visible;
    return listBox;
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    // add ingredient to list
    this.lstIngredients.Items.Add(this.txtNameIngredient.Text);
    // clear text box
    this.txtNameIngredient.Text = "";
    // update number of ingredients
    this.lblCurrNumber.Text = this.lstIngredients.Items.Count.ToString();
  }

  private void btnEdit_Click(object sender, EventArgs e)
  {
    // edit ingredient in list
    this.lstIngredients.Items[this.lstIngredients.SelectedIndex] = this.txtNameIngredient.Text;
    // clear text box
    this.txtNameIngredient.Text = "";
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    // delete ingredient from list
    this.lstIngredients.Items.RemoveAt(this.lstIngredients.SelectedIndex);
    // clear text box
    this.txtNameIngredient.Text = "";
    // update number of ingredients
    this.lblCurrNumber.Text = this.lstIngredients.Items.Count.ToString();
  }

  private void lstIngredients_SelectedIndexChanged(object sender, EventArgs e)
  {
    // display selected ingredient in text box
    this.txtNameIngredient.Text = this.lstIngredients.SelectedItem.ToString();
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    // save ingredients to recipe
    this.recipe.Ingredients = new string[this.lstIngredients.Items.Count];
    for (int i = 0; i < this.lstIngredients.Items.Count; i++)
    {
      this.recipe.Ingredients[i] = this.lstIngredients.Items[i].ToString();
    }
    // close form
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    // close form
    this.Close();
  }

  private void lblCurrNumber_Click(object sender, EventArgs e)
  {
    this.lblCurrNumber.Text = this.lstIngredients.Items.Count.ToString();
  }

}
