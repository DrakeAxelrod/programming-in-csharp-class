namespace a4;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private int HEIGHT = 800;
    private int WIDTH = 450;

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
    private System.Windows.Forms.List lstRecipes;
    private int maxNumOfElements;
    private int maxNumOfIngredients;
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
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(HEIGHT, WIDTH);
        this.Text = "Apu Recipe Book By Drake Axelrod";
    }

}
