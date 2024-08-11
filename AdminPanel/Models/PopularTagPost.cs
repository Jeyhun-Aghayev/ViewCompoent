namespace CSharp.ViewComponentTask.Models;

public class PopularTagPost 
{
    public int PostId { get; set; }
    public Post Post { get; set; } = null!;


    public int PopularTagId { get; set; }
    public PopularTag PopularTag { get; set; } = null!;
    
}