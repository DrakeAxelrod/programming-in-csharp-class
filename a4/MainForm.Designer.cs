namespace a4;

partial class MainForm
{
  /// <summary>
  ///  Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  private int HEIGHT = 480;
  private int WIDTH = 800;

  private System.Windows.Forms.Button btnAddIngredient;
  private System.Windows.Forms.Button btnAddRecipe;
  private System.Windows.Forms.Button btnClear;
  private System.Windows.Forms.Button btnDelete;
  private System.Windows.Forms.Button btnEditFinish;
  private System.Windows.Forms.Button btnEditStart;
  private System.Windows.Forms.ComboBox cmbFoodCategory;
  private Recipe currRecipe;
  private System.Windows.Forms.GroupBox grpAddRecipe;
  private System.Windows.Forms.Label lblCategory;
  private System.Windows.Forms.Label lblListCategory;
  private System.Windows.Forms.Label lblListNumIngredients;
  private System.Windows.Forms.Label lblListRecipe;
  private System.Windows.Forms.Label lblNameOfRecipe;
  private System.Windows.Forms.Label lblDoubleClick;
  private System.Windows.Forms.ListBox lstRecipes;
  private int maxNumOfElements = 100;
  private RecipeManager rp;
  private System.Windows.Forms.TextBox txtDescription;
  private System.Windows.Forms.TextBox txtNameRecipe;

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
    this.rp = new RecipeManager(maxNumOfElements);
    this.components = new System.ComponentModel.Container();
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(WIDTH, HEIGHT);
    this.Text = "Apu Recipe Book By Drake Axelrod";
    // center form
    this.StartPosition = FormStartPosition.CenterScreen;
    this.currRecipe = new Recipe();
    // init add recipe group box
    this.grpAddRecipe = initGrpBox(10, 10, WIDTH/2 - 20, HEIGHT- 20, "grpAddRecipe", "Add new Recipe", 0, false, true);
    this.Controls.Add(this.grpAddRecipe);
    // init name label and text box
    this.lblNameOfRecipe = initLabel(10, 20, 100, 20, "lblNameOfRecipe", "Name of Recipe:", 0, false, true);
    this.grpAddRecipe.Controls.Add(this.lblNameOfRecipe);
    this.txtNameRecipe = initTextBox(110, 20, 260, 20, "txtNameRecipe", "", 0, false, true);
    // event handler for name text box
    this.txtNameRecipe.TextChanged += new System.EventHandler(this.txtNameRecipe_TextChanged);
    this.grpAddRecipe.Controls.Add(this.txtNameRecipe);
    // init category label and combo box
    this.lblCategory = initLabel(10, 60, 100, 20, "lblCategory", "Category:", 0, false, true);
    this.grpAddRecipe.Controls.Add(this.lblCategory);
    this.cmbFoodCategory = initComboBox(110, 60, 150, 20, "cmbFoodCategory", 0, false, true);
    for (int i = 0; i < Enum.GetNames(typeof(FoodCategory)).Length; i++)
    {
      this.cmbFoodCategory.Items.Add(Enum.GetNames(typeof(FoodCategory))[i].Replace('_', ' '));
    }
    // default to other
    this.cmbFoodCategory.SelectedIndex = Enum.GetNames(typeof(FoodCategory)).Length - 1;
    // event handler for category combo box
    this.cmbFoodCategory.SelectedIndexChanged += new System.EventHandler(this.cmbFoodCategory_SelectedIndexChanged);
    this.grpAddRecipe.Controls.Add(this.cmbFoodCategory);
    // init add ingredient button
    this.btnAddIngredient = initButton(270, 60, 100, 24, "btnAddIngredient", "Add Ingredient", 0, false, true);
    this.grpAddRecipe.Controls.Add(this.btnAddIngredient);
    // event handler for add ingredient button
    this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
    // init description 
    this.txtDescription = initTextBox(10, 100, WIDTH/2 - 40, 300, "txtDescription", "", 0, false, true);
    // event handler for description text box
    this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
    // make it multiline
    this.txtDescription.Multiline = true;
    this.grpAddRecipe.Controls.Add(this.txtDescription);
    // init add recipe button
    this.btnAddRecipe = initButton(10, 420, WIDTH/2 - 40, 24, "btnAddRecipe", "Add Recipe", 0, false, true);
    // event handler for add recipe button
    this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
    this.grpAddRecipe.Controls.Add(this.btnAddRecipe);
    // init recipe name list label
    this.lblListRecipe = initLabel(WIDTH/2, 10, 100, 20, "lblListRecipe", "Recipe Name", 0, false, true);
    this.Controls.Add(this.lblListRecipe);
    // init category list label
    this.lblListCategory = initLabel(WIDTH/2 + 180, 10, 60, 20, "lblListCategory", "Category", 0, false, true);
    this.Controls.Add(this.lblListCategory);
    // init number of ingredients list label
    this.lblListNumIngredients = initLabel(WIDTH/2 + 310, 0, 80, 40, "lblListNumIngredients", "No. of Ingredients", 0, false, true);
    // center text
    this.lblListNumIngredients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    this.Controls.Add(this.lblListNumIngredients);
    // init recipe list box
    this.lstRecipes = initListBox(WIDTH/2, 40, WIDTH/2 - 20, HEIGHT - 110, "lstRecipes", 0, false, true);
    // double click event handler
    this.lstRecipes.DoubleClick += new System.EventHandler(this.lstRecipes_DoubleClick);
    this.Controls.Add(this.lstRecipes);
    // init edit start button
    this.btnEditStart = initButton(WIDTH/2, HEIGHT - 60, 80, 24, "btnEditStart", "Begin Edit", 0, false, true);
    // event handler for edit start button
    this.btnEditStart.Click += new System.EventHandler(this.btnEditRecipe_Click);
    this.Controls.Add(this.btnEditStart);
    // init edit finish button
    this.btnEditFinish = initButton(WIDTH/2 + 100, HEIGHT - 60, 80, 24, "btnEditFinish", "Finish Edit", 0, false, true);
    // event handler for edit finish button
    this.btnEditFinish.Click += new System.EventHandler(this.btnFinishEdit_Click);
    this.Controls.Add(this.btnEditFinish);
    // init delete button
    this.btnDelete = initButton(WIDTH/2 + 200, HEIGHT - 60, 80, 24, "btnDelete", "Delete", 0, false, true);
    // event handler for delete button
    this.btnDelete.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
    this.Controls.Add(this.btnDelete);
    // init clear button
    this.btnClear = initButton(WIDTH/2 + 300, HEIGHT - 60, 80, 24, "btnClear", "Clear", 0, false, true);
    // event handler for clear button
    this.btnClear.Click += new System.EventHandler(this.btnClearRecipeList_Click);
    this.Controls.Add(this.btnClear);
    // init text stating "Double click on an item for ingredients & cooking instructions!"
    this.lblDoubleClick = initLabel(WIDTH/2 + 30, HEIGHT - 30, 400, 20, "lblDoubleClick", "Double click on an item for ingredients & cooking instructions!", 0, false, true);
    // change text color to dark cyan
    this.lblDoubleClick.ForeColor = System.Drawing.Color.DarkCyan;
    this.Controls.Add(this.lblDoubleClick);

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

  private System.Windows.Forms.ComboBox initComboBox(int x, int y, int width, int height, string name, int tabIndex, bool tabStop, bool visible)
  {
    System.Windows.Forms.ComboBox comboBox = new System.Windows.Forms.ComboBox();
    comboBox.Location = new System.Drawing.Point(x, y);
    comboBox.Size = new System.Drawing.Size(width, height);
    comboBox.Name = name;
    comboBox.TabIndex = tabIndex;
    comboBox.TabStop = tabStop;
    comboBox.Visible = visible;
    return comboBox;
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

  // handle txtRecipeName text changed event
  private void txtNameRecipe_TextChanged(object sender, System.EventArgs e)
  {
    if (sender == this.txtNameRecipe)
    {
      this.currRecipe.Name = this.txtNameRecipe.Text;
    }
  }

  private void btnAddIngredient_Click(object sender, System.EventArgs e)
  {
    if (this.txtNameRecipe.Text == "")
    {
      MessageBox.Show("Please enter an recipe name!");
      return;
    }
    else
    {
      // open a new ingredient form
      IngredientsForm ingredientForm = new IngredientsForm(this.currRecipe);
      ingredientForm.Show();
    }
  }
  // handle food category combo box selected index changed event
  private void cmbFoodCategory_SelectedIndexChanged(object sender, System.EventArgs e)
  {
    if (sender == this.cmbFoodCategory)
    {
      // turn text into enum value
      this.currRecipe.Category = (FoodCategory)Enum.Parse(typeof(FoodCategory), this.cmbFoodCategory.SelectedItem.ToString());
    }
  }

  // hand txtDescription text changed event
  private void txtDescription_TextChanged(object sender, System.EventArgs e)
  {
    if (sender == this.txtDescription)
    {
      this.currRecipe.Description = this.txtDescription.Text;
    }
  }

  // add recipe button click event handler
  private void btnAddRecipe_Click(object sender, System.EventArgs e)
  {
    if (this.txtNameRecipe.Text == "")
    {
      MessageBox.Show("Please enter a recipe name!");
      return;
    }
    else
    {
      // add recipe to recipe list
      int idx = this.rp.FindVacantPosition();
      this.rp.AddAt(idx, this.currRecipe);
      // add recipe name to list box
      this.lstRecipes.Items.Add(this.currRecipe.Name);
      // current recipe is a new recipe
      this.currRecipe = new Recipe();
      // clear recipe name text box
      this.txtNameRecipe.Text = "";
      // clear description text box
      this.txtDescription.Text = "";
      this.cmbFoodCategory.SelectedIndex = this.cmbFoodCategory.Items.Count - 1;
      // set focus to recipe name text box
      this.txtNameRecipe.Focus();
    }
  }

  // handle double click event on list box
  private void lstRecipes_DoubleClick(object sender, System.EventArgs e)
  {
    if (sender == this.lstRecipes)
    {
      // template string for message box
      string content = "INGREDIENTS";
      // new line character
      content += System.Environment.NewLine;
      // for each ingredient in the recipe
      foreach (string ingredient in this.rp.GetRecipeAt(this.lstRecipes.SelectedIndex).Ingredients)
      {
        // add ingredient to content string
        content += ingredient;
        // new line character
        content += System.Environment.NewLine;
      }
      content += System.Environment.NewLine;
      content += "DESCRIPTION";
      content += System.Environment.NewLine;
      content += this.rp.GetRecipeAt(this.lstRecipes.SelectedIndex).Description;

      MessageBox.Show(content, this.rp.GetRecipeAt(this.lstRecipes.SelectedIndex).Name + " Cooking Instructions");
    }
  }
  // edit recipe handler
  private void btnEditRecipe_Click(object sender, System.EventArgs e)
  {
    if (this.lstRecipes.SelectedIndex == -1)
    {
      MessageBox.Show("Please select a recipe to edit!");
      return;
    }
    else
    {
      this.currRecipe = this.rp.GetRecipeAt(this.lstRecipes.SelectedIndex);
      this.txtNameRecipe.Text = this.currRecipe.Name;
      this.txtDescription.Text = this.currRecipe.Description;
      // set the combo box to the current recipe category
      this.cmbFoodCategory.SelectedIndex = (int)this.currRecipe.Category;
    }
  }

  // finish edit recipe handler
  private void btnFinishEdit_Click(object sender, System.EventArgs e)
  {
    if (this.txtNameRecipe.Text == "")
    {
      MessageBox.Show("Please enter a recipe name!");
      return;
    }
    else
    {
      this.rp.GetRecipeAt(this.lstRecipes.SelectedIndex).Name = this.txtNameRecipe.Text;
      this.rp.GetRecipeAt(this.lstRecipes.SelectedIndex).Description = this.txtDescription.Text;
      this.rp.GetRecipeAt(this.lstRecipes.SelectedIndex).Category = (FoodCategory)Enum.Parse(typeof(FoodCategory), this.cmbFoodCategory.SelectedItem.ToString());
      this.lstRecipes.Items[this.lstRecipes.SelectedIndex] = this.txtNameRecipe.Text;
      this.currRecipe = new Recipe();
      this.txtNameRecipe.Text = "";
      this.txtDescription.Text = "";
      this.cmbFoodCategory.SelectedIndex = this.cmbFoodCategory.Items.Count - 1;
      this.txtNameRecipe.Focus();
    }
  }

  // delete recipe handler
  private void btnDeleteRecipe_Click(object sender, System.EventArgs e)
  {
    if (this.lstRecipes.SelectedIndex == -1)
    {
      MessageBox.Show("Please select a recipe to delete!");
      return;
    }
    else
    {
      this.rp.DeleteElement(this.lstRecipes.SelectedIndex);
      this.lstRecipes.Items.RemoveAt(this.lstRecipes.SelectedIndex);
      this.currRecipe = new Recipe();
      this.txtNameRecipe.Text = "";
      this.txtDescription.Text = "";
      this.cmbFoodCategory.SelectedIndex = this.cmbFoodCategory.Items.Count - 1;
      this.txtNameRecipe.Focus();
    }
  }

  // clear recipe list handler
  private void btnClearRecipeList_Click(object sender, System.EventArgs e)
  {
    this.rp = new RecipeManager(maxNumOfElements);
    this.lstRecipes.Items.Clear();
  }
}
