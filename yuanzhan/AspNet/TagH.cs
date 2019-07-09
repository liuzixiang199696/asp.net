using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPage
{
    [HtmlTargetElement("DateTime", Attributes = "asp-showicon,asp-only")]
    public class DateTimeTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "small";
            string ASPSN = context.AllAttributes["asp-showicon"].Value.ToString();
            if (ASPSN == "true")
            {
                output.Content.SetHtmlContent($"<span class=\"glyphicon - calendar\"></span>{DateTime.Now.ToString("yyyy年MM月dd日  HH点mm分")}");
            }
            else
            {

            }
            string ASPoy = context.AllAttributes["asp-only"].Value.ToString();
            if (ASPoy =="date")
            {
                output.Content.SetContent($"{DateTime.Now.ToString("yyyy年MM月dd日")}");
            }
            else
            {

            }
        }
    }
}


