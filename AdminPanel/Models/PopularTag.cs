namespace CSharp.ViewComponentTask.Models;

public class PopularTag : BaseEntity
{
    public string Title { get; set; }
    public virtual ICollection<PopularTagPost>? PopularTagPosts { get; set; }
}