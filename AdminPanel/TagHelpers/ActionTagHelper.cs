using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CSharp.ViewComponentTask.TagHelpers;


[HtmlTargetElement("button", Attributes="btn-action")]
public class ActionTagHelper : TagHelper
{
    public string BtnAction { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
     

        (string color, string icon) btn = this.BtnAction switch
        {
            "delete" => ("danger", "trash"),
            "edit" => ("warning", "pen"),
            "create" => ("dark", "save"),
            _ => ("primary", "plus")
        };

      output.TagName = "button";
        output.Attributes.SetAttribute("class", $"btn btn-outline-{btn.color}");
        output.Attributes.SetAttribute("type", "submit");
        output.Content.SetHtmlContent($" <i class='fas fa-{btn.icon}'></i> {System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.BtnAction)}");
   }
}

public class DropDownActionTagHelper : TagHelper
{

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.Content.SetHtmlContent(@"
            <div class=""dropdown"">
              <button class=""btn btn-light btn-sm dropdown-toggle"" type=""button"" id=""dropdownMenuButton1"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
               <i class='fas fa-plus'> </i>
              </button>
              <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton1"">
                <li><a class=""dropdown-item"" href=""#"">Action</a></li>
                <li><a class=""dropdown-item"" href=""#"">Another action</a></li>
                <li><a class=""dropdown-item"" href=""#"">Something else here</a></li>
              </ul>
            </div> 
");
    }
}