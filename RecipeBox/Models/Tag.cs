using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Tag
  {
    public Tag()
    {
      this.Recipies = new HashSet<RecipeTag>();
    }

    public int TagId { get; set; }
    public string TagName { get; set; }
    public string TagDescription { get; set; }
    // public virtual ApplicationUser User { get; set; }
    public virtual ICollection<RecipeTag> Recipies { get; set; }
  }
}