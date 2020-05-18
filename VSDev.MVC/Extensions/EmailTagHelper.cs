using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace VSDev.MVC.Extensions
{
    public class EmailTagHelper : TagHelper
    {
        public string Domain { get; set; } = "hotmail.com";

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var content = await output.GetChildContentAsync();
            var target = content.GetContent() + "@" + Domain;

            output.TagName = "a";
            output.Attributes.Add("href", "mailto: " + target);
            output.Content.SetContent(target);
        }
    }
}
