namespace a4
{
  public class RecipeManager
  {
    private Recipe[] recipes;
    private int maxNumOfElements;

    public RecipeManager(int maxNumOfElements)
    {
      this.maxNumOfElements = maxNumOfElements;
      recipes = new Recipe[this.maxNumOfElements];
    }

    public void Add(Recipe recipe)
    {
      bool full = false;
      for (int i = 0; i < recipes.Length; i++)
      {
        if (recipes[i] == null)
        {
          recipes[i] = recipe;
          break;
        }
        else if (i == recipes.Length - 1)
        {
          full = true;
        }
      }
      if (full)
      {
        throw new Exception("Recipe array is full");
      }
    }
    public void Add(string name, RecipeCategory category, string[] ingredients)
    {
      Recipe recipe = new Recipe(name, category, ingredients);
      recipes.Add(recipe);
    }

    public void ChangeElement(int index, Recipe recipe)
    {
      recipes[index] = recipe;
    }

    public bool CheckIndex(int index)
    {
    }

    public void DeleteElement(int index)
    {
      if (index < 0 || index > recipes.Length)
      {
        throw new Exception("Index out of bounds");
      }
      else
      {
        recipes[index] = null;
      }
    }

    public int FindVacantPosition()
    {
      for (int i = 0; i < recipes.Length; i++)
      {
        if (recipes[i] == null)
        {
          return i;
        }
      }
      return -1;
    }

    public int GetCurrentNumberOfRecipes()
    {
      return recipes.Length;
    }

    public Recipe GetRecipeAt(int index)
    {
      if (index < recipes.Length)
      {
        return recipes[index];
      }
      else
      {
        return null;
      }
    }

    public string[] RecipeListToString()
    {
      string[] temp = new string[recipes.Length];
      for (int i = 0; i < recipes.Length; i++)
      {
        temp[i] = recipes[i].ToString();
      }
      return temp;
    }

  }
}
