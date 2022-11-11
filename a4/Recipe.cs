namespace a4
{
  public class Recipe
  {
    private FoodCategory category = FoodCategory.Other;
    private string description = "";
    private string[] ingredients = new string[0];
    private string name = "";

    // add capital variable names as properties for set and get
    public string Name
    {
      get { return name; }
      set { name = value; }
    }
    public string Description
    {
      get { return description; }
      set { description = value; }
    }
    public FoodCategory Category
    {
      get { return category; }
      set { category = value; }
    }
    public string[] Ingredients
    {
      get { return ingredients; }
      set { ingredients = value; }
    }
  }
}
