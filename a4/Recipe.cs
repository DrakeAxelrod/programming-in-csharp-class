namespace a4
{
  public class Recipe
  {
    private FoodCategory category { get; set; }
    private string description { get; set; }
    private string[] ingredients { get; set; }
    private string name { get; set; }

    public Recipe(int maxNumOfIngredients)
    {
      ingredients = new string[maxNumOfIngredients];
    }

  }
}
