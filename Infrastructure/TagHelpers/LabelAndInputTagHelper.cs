using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIB.Infrastructure.TagHelpers
{
    [HtmlTargetElement("label",Attributes ="helper-for")]
    [HtmlTargetElement("input", Attributes = "helper-for")]
    public class LabelAndInputTagHelper : TagHelper
    {
        public ModelExpression HelperFor { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (output.TagName == "label")
            {
                output.TagMode = TagMode.StartTagAndEndTag;
               
                output.Attributes.SetAttribute("asp-for", HelperFor.Name);
            }
            else if (output.TagName == "input")
            {
                output.TagMode = TagMode.SelfClosing;
                output.Attributes.SetAttribute("asp-for", HelperFor.Name);
                output.Attributes.SetAttribute("name", HelperFor.Name);
                output.Attributes.SetAttribute("id", HelperFor.Name);
                output.Attributes.SetAttribute("class", "form-control");
                if (HelperFor.Metadata.ModelType == typeof(long))
                {
                    output.Attributes.SetAttribute("type", "number");
                }
            }
        }
    }
}
