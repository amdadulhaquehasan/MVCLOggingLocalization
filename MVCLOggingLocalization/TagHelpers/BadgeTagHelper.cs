using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MVCLOggingLocalization.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("badge")]
    public class BadgeTagHelper : TagHelper
    {
        public string Type { get; set; } = "primary";
        public bool Pill { get; set; } = false;
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";

            var cssClass = $"badge bg-{Type}";
            if (Pill)
            {
                cssClass += $"round-pill";
            }
            output.Attributes.SetAttribute("class", cssClass);

            var content = await output.GetChildContentAsync();
            output.Content.SetHtmlContent(content.GetContent());
        }
    }
}
