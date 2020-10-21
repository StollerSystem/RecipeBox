using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public Recipe()
    {        
      this.Tags = new HashSet<RecipeTag>();      
    }
    public int RecipeId { get; set; }
    public string RecipeName { get; set; }
    public string RecipeInstructions { get; set; }
    public string RecipeRating { get; set; }
    public virtual ICollection<RecipeTag> MainTypes { get; set; }
  }
}